using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Markdig;

namespace MarkdownEditor.WinForms
{
    public partial class MainForm : Form
    {
        private string currentFilePath;
        private bool isDirty;
        private string? previewFilePath;

        // suppress double prompt when user confirmed exit via About/Exit flow
        private bool _suppressClosePrompt = false;

        public MainForm()
        {
            InitializeComponent();
            webPreview.AllowNavigation = true;
            rtbEditor.BackColor = Color.FromArgb(250, 250, 252);
            rtbEditor.BorderStyle = BorderStyle.None;
            rtbEditor.Margin = new Padding(12);

            this.Opacity = trkOpacity != null ? trkOpacity.Value / 100.0 : 0.95D;
            UpdateOpacityLabel();

            NewFile();
        }

        private void UpdateOpacityLabel()
        {
            if (lblOpacity != null && trkOpacity != null)
            {
                lblOpacity.Text = $"{trkOpacity.Value}%";
            }
        }

        private void trkOpacity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (trkOpacity != null)
                {
                    this.Opacity = trkOpacity.Value / 100.0;
                    UpdateOpacityLabel();
                    toolStripStatusLabel1.Text = $"Transparency: {trkOpacity.Value}%";
                }
            }
            catch { /* ignore UI update errors */ }
        }

        private void NewFile()
        {
            rtbEditor.Clear();
            currentFilePath = null;
            isDirty = false;
            UpdateTitle();
            UpdatePreview();
            toolStripStatusLabel1.Text = "New file";
        }

        private void LoadFile(string path)
        {
            try
            {
                rtbEditor.Text = File.ReadAllText(path);
                currentFilePath = path;
                isDirty = false;
                UpdateTitle();
                UpdatePreview();
                toolStripStatusLabel1.Text = $"Opened: {Path.GetFileName(path)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to open file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileAs();
                return;
            }

            try
            {
                File.WriteAllText(currentFilePath, rtbEditor.Text);
                isDirty = false;
                UpdateTitle();
                toolStripStatusLabel1.Text = $"Saved: {Path.GetFileName(currentFilePath)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to save file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFileAs()
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                saveFileDialog1.FileName = Path.GetFileName(currentFilePath);
            }
            else
            {
                saveFileDialog1.FileName = "Untitled.md";
            }

            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                currentFilePath = saveFileDialog1.FileName;
                SaveFile();
            }
        }

        private void UpdateTitle()
        {
            var name = string.IsNullOrEmpty(currentFilePath) ? "Untitled" : Path.GetFileName(currentFilePath);
            var dirtyFlag = isDirty ? "*" : string.Empty;
            Text = $"{name}{dirtyFlag} - Markdown Editor";
        }

        private void UpdatePreview()
        {
            try
            {
                var markdown = rtbEditor.Text ?? string.Empty;
                var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
                var body = Markdown.ToHtml(markdown, pipeline);

                var html = $@"
<!doctype html>
<html>
<head>
<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
<meta name=""theme-color"" content=""#ffffff"">
<link rel=""icon"" href=""data:,''"">
<style>
:root {{
  --accent: #0b76ef;
  --bg: #f6f8fa;
  --card: #ffffff;
  --muted: #6b7280;
  --radius: 10px;
  --max-width: 900px;
}}

* {{ box-sizing: border-box; }}
body {{
  margin: 0;
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial;
  background: linear-gradient(180deg, #f2f6fb 0%, #f6f8fa 100%);
  padding: 28px;
  color: #0f1720;
  -webkit-font-smoothing: antialiased;
}}

.container {{
  max-width: var(--max-width);
  margin: 0 auto;
  background: var(--card);
  padding: 28px;
  border-radius: var(--radius);
  box-shadow: 0 8px 30px rgba(16,24,40,0.08);
}}

h1,h2,h3,h4,h5,h6 {{
  color: #0f1720;
  font-weight: 600;
  margin-top: 1.2em;
  margin-bottom: 0.4em;
}}

p {{ line-height: 1.7; color: #111827; }}
a {{ color: var(--accent); text-decoration: none; }}
a:hover {{ text-decoration: underline; }}

pre {{
  background: #0b1220;
  color: #dbeafe;
  padding: 16px;
  border-radius: 8px;
  overflow: auto;
  font-family: Consolas, 'Courier New', monospace;
  font-size: 13px;
  line-height: 1.45;
}}

code {{
  background: rgba(27,31,35,0.04);
  padding: 0.15em 0.4em;
  border-radius: 6px;
  font-family: Consolas, 'Courier New', monospace;
  font-size: 0.95em;
}}

blockquote {{
  border-left: 4px solid rgba(11,118,239,0.18);
  padding-left: 12px;
  color: var(--muted);
  margin: 0.6em 0;
}}

table {{
  width: 100%;
  border-collapse: collapse;
  margin: 12px 0;
}}
th, td {{
  padding: 10px 12px;
  border: 1px solid #e6edf3;
  text-align: left;
}}
th {{
  background: linear-gradient(180deg, rgba(11,118,239,0.06), rgba(11,118,239,0.02));
}}

img {{
  max-width: 100%;
  height: auto;
  border-radius: 8px;
  display: block;
  margin: 12px 0;
}}

.footer {{
  margin-top: 18px;
  font-size: 12px;
  color: var(--muted);
  text-align: right;
}}
</style>
</head>
<body>
<div class=""container"">
{body}
<div class=""footer"">Rendered by Markdown Editor</div>
</div>
</body>
</html>";

                try
                {
                    if (!string.IsNullOrEmpty(previewFilePath) && File.Exists(previewFilePath))
                    {
                        File.Delete(previewFilePath);
                    }
                }
                catch { /* ignore cleanup errors */ }

                var tempPath = Path.Combine(Path.GetTempPath(), $"mdpreview_{Guid.NewGuid():N}.html");
                File.WriteAllText(tempPath, html);
                previewFilePath = tempPath;

                webPreview.Navigate(previewFilePath);
                toolStripStatusLabel1.Text = "Preview updated";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = $"Preview error: {ex.Message}";
            }
        }

        private void MarkDirty()
        {
            if (!isDirty)
            {
                isDirty = true;
                UpdateTitle();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using var about = new AboutForm();
            about.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // First ask about saving changes
            if (!PromptSaveIfNeeded()) return;

            // Confirm exit once; if confirmed, suppress the OnFormClosing prompt
            var result = MessageBox.Show(this, "Do you really want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _suppressClosePrompt = true;
                Close();
            }
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            MarkDirty();

            // debounce preview updates
            renderTimer.Stop();
            renderTimer.Start();
        }

        private void renderTimer_Tick(object sender, EventArgs e)
        {
            renderTimer.Stop();
            UpdatePreview();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // If we already confirmed exit via the Exit button, skip the second prompt
            if (_suppressClosePrompt)
            {
                _suppressClosePrompt = false;
                base.OnFormClosing(e);
                return;
            }

            if (!PromptSaveIfNeeded())
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }

        private bool PromptSaveIfNeeded()
        {
            if (!isDirty) return true;

            var result = MessageBox.Show(this, "You have unsaved changes. Save now?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SaveFile();
                return !isDirty; // If save failed, still dirty
            }

            if (result == DialogResult.No) return true;

            return false; // Cancel
        }

        // Toggles visibility of the preview pane and updates button text
        private void tsbTogglePreview_Click(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
                // update the button label (we find button by name, designer wires btnTogglePreview)
                if (this.Controls.Find("topPanel", true).Length > 0)
                {
                    var panel = this.Controls["topPanel"];
                    var btn = panel.Controls["btnTogglePreview"] as Button;
                    if (btn != null)
                    {
                        btn.Text = splitContainer1.Panel2Collapsed ? "\ud83d\udc41  Show Preview" : "\ud83d\udc41  Hide Preview";
                    }
                }
            }
            catch { }
        }
    }
}