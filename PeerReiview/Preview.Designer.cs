namespace PeerReiview
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.lblCommentID = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblReviewerName = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewfile = new AxAcroPDFLib.AxAcroPDF();
            this.quit = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.viewfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommentID
            // 
            this.lblCommentID.AutoSize = true;
            this.lblCommentID.Location = new System.Drawing.Point(313, 248);
            this.lblCommentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentID.Name = "lblCommentID";
            this.lblCommentID.Size = new System.Drawing.Size(0, 13);
            this.lblCommentID.TabIndex = 13;
            this.lblCommentID.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Tomato;
            this.btnSend.Location = new System.Drawing.Point(257, 375);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 19);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblReviewerName
            // 
            this.lblReviewerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReviewerName.Location = new System.Drawing.Point(139, 317);
            this.lblReviewerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewerName.Name = "lblReviewerName";
            this.lblReviewerName.Size = new System.Drawing.Size(148, 19);
            this.lblReviewerName.TabIndex = 11;
            this.lblReviewerName.Click += new System.EventHandler(this.lblReviewerName_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(356, 281);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(269, 84);
            this.txtComment.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reviewer Name";
            // 
            // viewfile
            // 
            this.viewfile.Enabled = true;
            this.viewfile.Location = new System.Drawing.Point(8, 9);
            this.viewfile.Margin = new System.Windows.Forms.Padding(2);
            this.viewfile.Name = "viewfile";
            this.viewfile.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("viewfile.OcxState")));
            this.viewfile.Size = new System.Drawing.Size(617, 268);
            this.viewfile.TabIndex = 7;
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(22, 392);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(33, 13);
            this.quit.TabIndex = 14;
            this.quit.TabStop = true;
            this.quit.Text = "Close";
            this.quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quit_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(136, 392);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 414);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.lblCommentID);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblReviewerName);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewfile);
            this.Name = "Preview";
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.Preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommentID;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblReviewerName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxAcroPDFLib.AxAcroPDF viewfile;
        private System.Windows.Forms.LinkLabel quit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}