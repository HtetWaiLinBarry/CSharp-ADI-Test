namespace PeerReiview
{
    partial class DetailComment
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
            this.dgvcdisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcdisplay
            // 
            this.dgvcdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcdisplay.Location = new System.Drawing.Point(1, -1);
            this.dgvcdisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcdisplay.Name = "dgvcdisplay";
            this.dgvcdisplay.RowTemplate.Height = 24;
            this.dgvcdisplay.Size = new System.Drawing.Size(781, 307);
            this.dgvcdisplay.TabIndex = 1;
            this.dgvcdisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplay_CellClick);
            this.dgvcdisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcdisplay_CellContentClick);
            // 
            // DetailComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 317);
            this.Controls.Add(this.dgvcdisplay);
            this.Name = "DetailComment";
            this.Text = "DetailComment";
            this.Load += new System.EventHandler(this.DetailComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcdisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcdisplay;

    }
}