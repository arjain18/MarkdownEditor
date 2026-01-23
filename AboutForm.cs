using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MarkdownEditor.WinForms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            // If you prefer to read version from the assembly:
            // lblVersion.Text = $"Version: {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void linkWebsite_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var url = (sender as LinkLabel)?.Text ?? "www.sqamanual.com";
                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            }
            catch { /* ignore */ }
        }

        private void btnClose_Click(object? sender, EventArgs e) => Close();
    }
}