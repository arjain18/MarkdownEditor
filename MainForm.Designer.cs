namespace MarkdownEditor.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.WebBrowser webPreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer renderTimer;

        // New top button bar
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTogglePreview;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;

        // UI additions: opacity slider, label and tooltips
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.ToolTip toolTip1;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            rtbEditor = new System.Windows.Forms.RichTextBox();
            webPreview = new System.Windows.Forms.WebBrowser();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            renderTimer = new System.Windows.Forms.Timer(components);

            topPanel = new System.Windows.Forms.Panel();
            btnNew = new System.Windows.Forms.Button();
            btnOpen = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnTogglePreview = new System.Windows.Forms.Button();
            btnAbout = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();

            // New controls
            trkOpacity = new System.Windows.Forms.TrackBar();
            lblOpacity = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);

            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkOpacity).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 56;
            topPanel.Padding = new Padding(12, 8, 12, 8);
            topPanel.BackColor = System.Drawing.Color.Transparent;

            // Create and add controls to topPanel in logical left-to-right order.
            // We'll position the right-side buttons after adding topPanel to the form so ClientSize is known.
            topPanel.Controls.Add(btnNew);
            topPanel.Controls.Add(btnOpen);
            topPanel.Controls.Add(btnSave);
            topPanel.Controls.Add(btnTogglePreview);
            topPanel.Controls.Add(trkOpacity);
            topPanel.Controls.Add(lblOpacity);
            topPanel.Controls.Add(btnAbout);
            topPanel.Controls.Add(btnExit);
            // 
            // btnNew
            // 
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.BackColor = Color.FromArgb(250, 250, 252);
            btnNew.ForeColor = Color.FromArgb(15, 23, 36);
            btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnNew.Text = "\ud83c\udd95  New";
            btnNew.Width = 110;
            btnNew.Height = 40;
            btnNew.Location = new System.Drawing.Point(12, 8);
            btnNew.Click += newToolStripMenuItem_Click;
            toolTip1.SetToolTip(btnNew, "Create a new document");
            // 
            // btnOpen
            // 
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.BackColor = Color.FromArgb(250, 250, 252);
            btnOpen.ForeColor = Color.FromArgb(15, 23, 36);
            btnOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btnOpen.Text = "\ud83d\udcc2  Open";
            btnOpen.Width = 100;
            btnOpen.Height = 40;
            btnOpen.Location = new System.Drawing.Point(132, 8);
            btnOpen.Click += openToolStripMenuItem_Click;
            toolTip1.SetToolTip(btnOpen, "Open an existing markdown file");
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.BackColor = Color.FromArgb(11, 118, 239);
            btnSave.ForeColor = Color.White;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSave.Text = "\ud83d\udcbe  Save";
            btnSave.Width = 100;
            btnSave.Height = 40;
            btnSave.Location = new System.Drawing.Point(244, 8);
            btnSave.Click += saveToolStripMenuItem_Click;
            toolTip1.SetToolTip(btnSave, "Save current document");
            // 
            // btnTogglePreview
            // 
            btnTogglePreview.FlatStyle = FlatStyle.Flat;
            btnTogglePreview.FlatAppearance.BorderSize = 0;
            btnTogglePreview.BackColor = Color.FromArgb(250, 250, 252);
            btnTogglePreview.ForeColor = Color.FromArgb(15, 23, 36);
            btnTogglePreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btnTogglePreview.Text = "\ud83d\udc41  Hide Preview";
            btnTogglePreview.Width = 140;
            btnTogglePreview.Height = 40;
            btnTogglePreview.Location = new System.Drawing.Point(356, 8);
            btnTogglePreview.Click += tsbTogglePreview_Click;
            toolTip1.SetToolTip(btnTogglePreview, "Show or hide the HTML preview");
            // 
            // trkOpacity
            // 
            trkOpacity.Minimum = 50;
            trkOpacity.Maximum = 100;
            trkOpacity.Value = 95;
            trkOpacity.TickFrequency = 5;
            trkOpacity.Width = 140;
            trkOpacity.Height = 40;
            trkOpacity.Location = new System.Drawing.Point(506, 8);
            trkOpacity.Scroll += new System.EventHandler(trkOpacity_ValueChanged);
            toolTip1.SetToolTip(trkOpacity, "Adjust window transparency (50% - 100%)");
            // 
            // lblOpacity
            // 
            lblOpacity.AutoSize = true;
            lblOpacity.Location = new System.Drawing.Point(656, 18);
            lblOpacity.Width = 48;
            lblOpacity.Text = "95%";
            toolTip1.SetToolTip(lblOpacity, "Current transparency");
            // 
            // btnAbout
            // 
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.BackColor = Color.FromArgb(250, 250, 252);
            btnAbout.ForeColor = Color.FromArgb(15, 23, 36);
            btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btnAbout.Text = "\u2139  About";
            btnAbout.Width = 100;
            btnAbout.Height = 40;
            btnAbout.Click += btnAbout_Click;
            toolTip1.SetToolTip(btnAbout, "About this application");
            // keep anchor set; Location will be assigned after Controls are added to the form
            btnAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.BackColor = Color.Transparent;
            btnExit.ForeColor = Color.FromArgb(196, 40, 28); // more visible exit color
            btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btnExit.Text = "Exit";
            btnExit.Width = 90;
            btnExit.Height = 40;
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Click += exitToolStripMenuItem_Click;
            toolTip1.SetToolTip(btnExit, "Exit application (you will be asked to confirm)");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, topPanel.Height);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Panel1.Controls.Add(rtbEditor);
            splitContainer1.Panel2.Controls.Add(webPreview);
            splitContainer1.Size = new System.Drawing.Size(954, 685);
            splitContainer1.SplitterDistance = 477;
            splitContainer1.TabIndex = 1;
            // 
            // rtbEditor
            // 
            rtbEditor.AcceptsTab = true;
            rtbEditor.Dock = DockStyle.Fill;
            rtbEditor.Font = new System.Drawing.Font("Consolas", 10F);
            rtbEditor.Location = new System.Drawing.Point(0, 0);
            rtbEditor.Name = "rtbEditor";
            rtbEditor.Size = new System.Drawing.Size(477, 685);
            rtbEditor.TabIndex = 0;
            rtbEditor.Text = "";
            rtbEditor.TextChanged += rtbEditor_TextChanged;
            // 
            // webPreview
            // 
            webPreview.AllowNavigation = false;
            webPreview.Dock = DockStyle.Fill;
            webPreview.Location = new System.Drawing.Point(0, 0);
            webPreview.MinimumSize = new System.Drawing.Size(20, 20);
            webPreview.Name = "webPreview";
            webPreview.Size = new System.Drawing.Size(473, 685);
            webPreview.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelVersion });
            statusStrip1.Location = new System.Drawing.Point(0, 725);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 1, 0);
            statusStrip1.Size = new System.Drawing.Size(954, 28);
            statusStrip1.TabIndex = 3;
            statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(78, 23);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripStatusLabelVersion
            // 
            toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            toolStripStatusLabelVersion.Size = new System.Drawing.Size(100, 23);
            toolStripStatusLabelVersion.Text = "Version: 1.0.0";
            toolStripStatusLabelVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            // 
            // renderTimer
            // 
            renderTimer.Interval = 300;
            renderTimer.Tick += renderTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(954, 767);

            // Add controls to form
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(topPanel);

            // Now that ClientSize and control sizes are known, position the right-side buttons.
            // Put Exit at extreme right and About immediately to its left.
            btnExit.Location = new System.Drawing.Point(this.ClientSize.Width - btnExit.Width - 16, 8);
            btnAbout.Location = new System.Drawing.Point(btnExit.Left - btnAbout.Width - 8, 8);

            // Ensure they are visible on top and respond to resizing.
            btnExit.BringToFront();
            btnAbout.BringToFront();
            this.Resize += (s, e) =>
            {
                btnExit.Location = new System.Drawing.Point(this.ClientSize.Width - btnExit.Width - 16, 8);
                btnAbout.Location = new System.Drawing.Point(btnExit.Left - btnAbout.Width - 8, 8);
            };

            // Make the window slightly transparent to achieve a modern, airy feel.
            this.Opacity = 0.95D;

            Name = "MainForm";
            Text = "Markdown Editor";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trkOpacity).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}