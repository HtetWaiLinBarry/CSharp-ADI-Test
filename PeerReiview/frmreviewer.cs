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
    public partial class frmreviewer : Form
    {

        PeerReviewDataSetTableAdapters.ReviewerTableAdapter reviewerds = new PeerReviewDataSetTableAdapters.ReviewerTableAdapter();
        public static String reviewer_name, reviewerid;
        public static String reviewername;

        public frmreviewer()
        {
            InitializeComponent();
        }

        public void ReviewerAutoID()
        {
            DataTable dt = new DataTable();
            dt = reviewerds.GetData();
            if (dt.Rows.Count == 0)
            {
                lblReviewer.Text = "R_001";
                reviewerid = lblReviewer.Text;
            }
            else
            {
                int size = dt.Rows.Count - 1;

                String oldid = dt.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblReviewer.Text = "R_00" + (newid + 1);
                    reviewerid = lblReviewer.Text;
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblReviewer.Text = "R_0" + (newid + 1);
                    reviewerid = lblReviewer.Text;
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblReviewer.Text = "R_" + (newid + 1);
                    reviewerid = lblReviewer.Text;
                }
            }
        }

        private void frmreviewer_Load(object sender, EventArgs e)
        {
            ReviewerAutoID();
            lblReviewer.Visible = false;
            lblReviewDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string skill = cboSkill.SelectedItem.ToString();
            clsreviewer re = new clsreviewer();
            re.reviewerid = lblReviewer.Text;
            re.reviewername = txtrn.Text;
            re.reviewerdate = lblReviewDate.Text;
            re.reviewerskill = skill;

            DataTable dt = new DataTable();
            dt = reviewerds.SelectReviewerName(re.reviewername);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Reviewer Name is in same", "Reviewer Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtrn.Text == "")
                {
                    MessageBox.Show("Please Fill Reviewer Name", "Reviewer Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrn.Focus();
                }
                else if (cboSkill.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Choose Skill", "Reviewer Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrn.Focus();
                }
                else
                {
                    int count = reviewerds.Insert(re.reviewerid, re.reviewername, re.reviewerdate, re.reviewerskill);
                    if (count > 0)
                    {
                        MessageBox.Show("Saved Reviewer Succcessfully", "Reviewer Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reviewer_name = txtrn.Text;
                        this.Hide();
                        DocumentList dc = new DocumentList();
                        dc.ShowDialog();
                        txtrn.Text = "";
                        cboSkill.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Something wrong in save Reviewer", "Reviewer Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboSkill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
