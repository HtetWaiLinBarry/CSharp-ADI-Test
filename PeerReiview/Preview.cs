using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeerReiview
{
    public partial class Preview : Form
    {
        PeerReviewDataSetTableAdapters.DocumentTableAdapter ds = new PeerReviewDataSetTableAdapters.DocumentTableAdapter();
        PeerReviewDataSetTableAdapters.CommentTableAdapter cs = new PeerReviewDataSetTableAdapters.CommentTableAdapter();

        public Preview()
        {
            InitializeComponent();
        }
        public void ReviewerAutoID()
        {
            DataTable dt = new DataTable();
            dt = cs.GetData();
            if (dt.Rows.Count == 0)
            {
                lblCommentID.Text = "C_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;

                String oldid = dt.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblCommentID.Text = "C_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblCommentID.Text = "C_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblCommentID.Text = "C_" + (newid + 1);
                }
            }
        }


        private void Preview_Load(object sender, EventArgs e)
        {
            ReviewerAutoID();
            String reviewer = frmreviewer.reviewer_name;
            if (reviewer.ToString() == "")
            {
                MessageBox.Show("Incorrect Reviewer", "Reviewer Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmreviewer r = new frmreviewer();
                this.Hide();
               
            }
            else
            {
                lblReviewerName.Text = reviewer;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String commentdate = DateTime.Now.ToString("dd/MM/yyyy");
            clsComment co = new clsComment();
            co.commentid = lblCommentID.Text;
            co.documentid = DocumentList.docid;
            co.reviewerid = frmreviewer.reviewerid;
            co.description = txtComment.Text;
            co.commentdate = commentdate.ToString();

            if (txtComment.Text == "")
            {
                MessageBox.Show("Please Type Comment", "Comment Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComment.Focus();
            }
            else
            {
                int data = cs.InsertQuery(co.commentid, co.reviewerid, co.documentid, co.description,co.commentdate);
                if (data > 0)
                {
                    MessageBox.Show("Comment Saved Successfully", "Comment Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Try Again", "Comment Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
          

        }

        private void quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lblReviewerName_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();

        }
    }
}
