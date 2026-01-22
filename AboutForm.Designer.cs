namespace MarkdownEditor.WinForms
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClose;

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
            lblAppName = new System.Windows.Forms.Label();
            lblVersion = new System.Windows.Forms.Label();
            linkWebsite = new System.Windows.Forms.LinkLabel();
            txtDescription = new System.Windows.Forms.TextBox();
            btnClose = new System.Windows.Forms.Button();

            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblAppName.Location = new System.Drawing.Point(16, 16);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(180, 28);
            lblAppName.Text = "Markdown Editor";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(18, 52);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(80, 20);
            lblVersion.Text = "Version: 1.0.0";
            // 
            // linkWebsite
            // 
            linkWebsite.AutoSize = true;
            linkWebsite.Location = new System.Drawing.Point(18, 80);
            linkWebsite.Name = "linkWebsite";
            linkWebsite.Size = new System.Drawing.Size(150, 20);
            linkWebsite.Text = "https://example.com";
            linkWebsite.LinkClicked += linkWebsite_LinkClicked;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(18, 110);
            txtDescription.Multiline = true;
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(420, 120);
            txtDescription.Text = "Simple markdown editor with live preview. Edit, save, and preview markdown files.";
            // 
            // btnClose
            // 
            btnClose.Text = "Close";
            btnClose.Width = 100;
            btnClose.Height = 34;
            btnClose.Location = new System.Drawing.Point(338, 240);
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            ClientSize = new System.Drawing.Size(460, 290);
            Controls.Add(lblAppName);
            Controls.Add(lblVersion);
            Controls.Add(linkWebsite);
            Controls.Add(txtDescription);
            Controls.Add(btnClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}