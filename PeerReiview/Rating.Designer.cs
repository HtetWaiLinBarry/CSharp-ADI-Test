namespace PeerReiview
{
    partial class Rating
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
            this.btnRate = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.LinkLabel();
            this.lblr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.Tomato;
            this.btnRate.Location = new System.Drawing.Point(193, 179);
            this.btnRate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(77, 24);
            this.btnRate.TabIndex = 15;
            this.btnRate.Text = "&Rate";
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Tomato;
            this.btnFive.Location = new System.Drawing.Point(396, 92);
            this.btnFive.Margin = new System.Windows.Forms.Padding(2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(52, 41);
            this.btnFive.TabIndex = 14;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click_1);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.LightCoral;
            this.btnFour.Location = new System.Drawing.Point(344, 92);
            this.btnFour.Margin = new System.Windows.Forms.Padding(2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(48, 41);
            this.btnFour.TabIndex = 13;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click_1);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Salmon;
            this.btnThree.Location = new System.Drawing.Point(293, 92);
            this.btnThree.Margin = new System.Windows.Forms.Padding(2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(47, 41);
            this.btnThree.TabIndex = 12;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click_1);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.LightSalmon;
            this.btnTwo.Location = new System.Drawing.Point(243, 92);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(46, 41);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click_1);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.MistyRose;
            this.btnOne.Location = new System.Drawing.Point(193, 92);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(46, 41);
            this.btnOne.TabIndex = 10;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rating Score";
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.Location = new System.Drawing.Point(11, 293);
            this.quit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(33, 13);
            this.quit.TabIndex = 16;
            this.quit.TabStop = true;
            this.quit.Text = "Close";
            this.quit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quit_LinkClicked);
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(309, 247);
            this.lblr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(0, 13);
            this.lblr.TabIndex = 17;
            this.lblr.Click += new System.EventHandler(this.lblr_Click);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 315);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.label1);
            this.Name = "Rating";
            this.Text = "Rating";
            this.Load += new System.EventHandler(this.Rating_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel quit;
        private System.Windows.Forms.Label lblr;


    }
}