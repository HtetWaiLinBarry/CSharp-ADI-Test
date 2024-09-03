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
    public partial class Rating : Form
    {
        PeerReviewDataSetTableAdapters.RatingTableAdapter dr = new PeerReviewDataSetTableAdapters.RatingTableAdapter();
        int one, two, three, four, five;
        String rid;

        public Rating()
        {
            InitializeComponent();
        }
        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = dr.GetData();
            if (dt.Rows.Count == 0)
            {
                rid = "S_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;

                String oldid = dt.Rows[size][0].ToString();

                int newid = Convert.ToInt32(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    rid = "S_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    rid = "S_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    rid = "S_" + (newid + 1);
                }
            }
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            AutoID();
        }


        private void btnra_Click(object sender, EventArgs e)
        {
        }

        private void btnOne_Click(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

        }

        private void btnFour_Click(object sender, EventArgs e)
        {

        }

        private void btnFive_Click(object sender, EventArgs e)
        {

        }

        private void btnFour_Click_1(object sender, EventArgs e)
        {
            four = 4;
        }

        private void btnFive_Click_1(object sender, EventArgs e)
        {
            five = 5;
        }

        private void btnThree_Click_1(object sender, EventArgs e)
        {
            three = 3;
        }

        private void btnTwo_Click_1(object sender, EventArgs e)
        {
            two = 2;
        }

        private void btnOne_Click_1(object sender, EventArgs e)
        {
            one = 1;
        }
        
        private void btnRate_Click(object sender, EventArgs e)
        {
           
                int dt;
                if (one == 1)
                {
                    try
                    {
                        dt = dr.InsertRating(rid.ToString(), DetailComment.did.ToString(), Convert.ToInt32(one));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (two == 2)
                {
                    dt = dr.InsertRating(rid.ToString(), DetailComment.did.ToString(), Convert.ToInt32(two));
                }
                else if (three == 3)
                {
                    dt = dr.InsertRating(rid.ToString(), DetailComment.did.ToString(), Convert.ToInt32(three));
                }
                else if (four == 4)
                {
                    dt = dr.InsertRating(rid.ToString(), DetailComment.did.ToString(), Convert.ToInt32(four));
                }
                else
                {
                    dt = dr.InsertRating(rid.ToString(), DetailComment.did.ToString(), Convert.ToInt32(five));
                }
                MessageBox.Show("Thank You For Rating Us.");
            }
  
            
        
        private void quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lblr_Click(object sender, EventArgs e)
        {
            AutoID();
        }
    }
}
