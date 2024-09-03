namespace PeerReiview
{
    partial class PeerReview
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
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnReviewer = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.Tomato;
            this.btnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.Location = new System.Drawing.Point(11, 32);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(194, 56);
            this.btnAuthor.TabIndex = 3;
            this.btnAuthor.Text = "I am Author.";
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnReviewer
            // 
            this.btnReviewer.BackColor = System.Drawing.Color.Tomato;
            this.btnReviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewer.Location = new System.Drawing.Point(79, 139);
            this.btnReviewer.Margin = new System.Windows.Forms.Padding(2);
            this.btnReviewer.Name = "btnReviewer";
            this.btnReviewer.Size = new System.Drawing.Size(194, 56);
            this.btnReviewer.TabIndex = 2;
            this.btnReviewer.Text = "I am Reviewer";
            this.btnReviewer.UseVisualStyleBackColor = false;
            this.btnReviewer.Click += new System.EventHandler(this.btnReviewer_Click);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(11, 239);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(26, 13);
            this.quit.TabIndex = 6;
            this.quit.TabStop = true;
            this.quit.Text = "Quit";
            this.quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quit_LinkClicked);
            // 
            // PeerReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnReviewer);
            this.Name = "PeerReview";
            this.Text = "PeerReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnReviewer;
        private System.Windows.Forms.LinkLabel quit;
    }
}