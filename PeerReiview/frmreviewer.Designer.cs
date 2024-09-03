namespace PeerReiview
{
    partial class frmreviewer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.cboSkill = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.lblReviewDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblReviewer);
            this.groupBox1.Controls.Add(this.cboSkill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtrn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(267, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reviewer Info:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Tomato;
            this.btnRecord.Location = new System.Drawing.Point(106, 123);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(56, 27);
            this.btnRecord.TabIndex = 7;
            this.btnRecord.Text = "&Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.Location = new System.Drawing.Point(104, 94);
            this.lblReviewDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(0, 13);
            this.lblReviewDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Review Date";
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(243, 15);
            this.lblReviewer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(0, 13);
            this.lblReviewer.TabIndex = 4;
            // 
            // cboSkill
            // 
            this.cboSkill.FormattingEnabled = true;
            this.cboSkill.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Patient"});
            this.cboSkill.Location = new System.Drawing.Point(106, 58);
            this.cboSkill.Margin = new System.Windows.Forms.Padding(2);
            this.cboSkill.Name = "cboSkill";
            this.cboSkill.Size = new System.Drawing.Size(134, 21);
            this.cboSkill.TabIndex = 3;
            this.cboSkill.SelectedIndexChanged += new System.EventHandler(this.cboSkill_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skill of Reviewer";
            // 
            // txtrn
            // 
            this.txtrn.Location = new System.Drawing.Point(106, 27);
            this.txtrn.Margin = new System.Windows.Forms.Padding(2);
            this.txtrn.Name = "txtrn";
            this.txtrn.Size = new System.Drawing.Size(134, 20);
            this.txtrn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reviewer Name";
            // 
            // frmreviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 183);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmreviewer";
            this.Text = "frmreviewer";
            this.Load += new System.EventHandler(this.frmreviewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.ComboBox cboSkill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrn;
        private System.Windows.Forms.Label label1;
    }
}