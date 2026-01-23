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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lblAppName = new Label();
            lblVersion = new Label();
            linkWebsite = new LinkLabel();
            txtDescription = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAppName.Location = new Point(18, 16);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(640, 58);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Markdown Editor";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            lblVersion.Font = new Font("Segoe UI", 10F);
            lblVersion.Location = new Point(18, 88);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(640, 43);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version: 1.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkWebsite
            // 
            linkWebsite.Font = new Font("Segoe UI", 9F);
            linkWebsite.Location = new Point(18, 131);
            linkWebsite.Name = "linkWebsite";
            linkWebsite.Size = new Size(640, 51);
            linkWebsite.TabIndex = 2;
            linkWebsite.TabStop = true;
            linkWebsite.Text = "https://www.sqamanual.com";
            linkWebsite.TextAlign = ContentAlignment.MiddleLeft;
            linkWebsite.LinkClicked += linkWebsite_LinkClicked;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Control;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(18, 203);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(640, 284);
            txtDescription.TabIndex = 3;
            txtDescription.TabStop = false;
            txtDescription.Text = resources.GetString("txtDescription.Text");
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(584, 505);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 45);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            ClientSize = new Size(686, 566);
            Controls.Add(lblAppName);
            Controls.Add(lblVersion);
            Controls.Add(linkWebsite);
            Controls.Add(txtDescription);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}