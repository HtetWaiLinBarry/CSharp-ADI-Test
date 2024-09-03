namespace PeerReiview
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblauthorname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchRatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerReviewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblauthorname
            // 
            this.lblauthorname.AutoSize = true;
            this.lblauthorname.Location = new System.Drawing.Point(11, 39);
            this.lblauthorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblauthorname.Name = "lblauthorname";
            this.lblauthorname.Size = new System.Drawing.Size(0, 13);
            this.lblauthorname.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuExit,
            this.registerReviewerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(152, 22);
            this.mnuLogin.Text = "&Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDocument});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.recordToolStripMenuItem.Text = "&Record";
            // 
            // mnuDocument
            // 
            this.mnuDocument.Name = "mnuDocument";
            this.mnuDocument.Size = new System.Drawing.Size(130, 22);
            this.mnuDocument.Text = "&Document";
            this.mnuDocument.Click += new System.EventHandler(this.mnuDocument_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchDocument,
            this.searchCommentToolStripMenuItem,
            this.searchRatingToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // mnuSearchDocument
            // 
            this.mnuSearchDocument.Name = "mnuSearchDocument";
            this.mnuSearchDocument.Size = new System.Drawing.Size(165, 22);
            this.mnuSearchDocument.Text = "Search&Document";
            this.mnuSearchDocument.Click += new System.EventHandler(this.mnuSearchDocument_Click);
            // 
            // searchCommentToolStripMenuItem
            // 
            this.searchCommentToolStripMenuItem.Name = "searchCommentToolStripMenuItem";
            this.searchCommentToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.searchCommentToolStripMenuItem.Text = "Search&Comment";
            this.searchCommentToolStripMenuItem.Click += new System.EventHandler(this.searchCommentToolStripMenuItem_Click);
            // 
            // searchRatingToolStripMenuItem
            // 
            this.searchRatingToolStripMenuItem.Name = "searchRatingToolStripMenuItem";
            this.searchRatingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.searchRatingToolStripMenuItem.Text = "Search &Rating";
            this.searchRatingToolStripMenuItem.Click += new System.EventHandler(this.searchRatingToolStripMenuItem_Click);
            // 
            // registerReviewerToolStripMenuItem
            // 
            this.registerReviewerToolStripMenuItem.Name = "registerReviewerToolStripMenuItem";
            this.registerReviewerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registerReviewerToolStripMenuItem.Text = "Register Reviewer";
            this.registerReviewerToolStripMenuItem.Click += new System.EventHandler(this.registerReviewerToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 425);
            this.Controls.Add(this.lblauthorname);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblauthorname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDocument;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchDocument;
        private System.Windows.Forms.ToolStripMenuItem searchCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchRatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerReviewerToolStripMenuItem;
    }
}