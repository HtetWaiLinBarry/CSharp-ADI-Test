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
    public partial class Author : Form
    {
        PeerReviewDataSetTableAdapters.AuthorTableAdapter authords = new PeerReviewDataSetTableAdapters.AuthorTableAdapter();
        public static String AID, authorname;
        public Author()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = authords.GetData();
            if (dt.Rows.Count == 0)
            {
                lblauthorid.Text = "A_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;

                String oldid = dt.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblauthorid.Text = "A_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    lblauthorid.Text = "A_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    lblauthorid.Text = "A_" + (newid + 1);
                }
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            clsAuthor author = new clsAuthor();
            author.authorid = lblauthorid.Text;
            author.authorname = txtauthorname.Text;
            author.emailaddress = txtemail.Text;
            author.username = txtusername.Text;
            author.password = txtpassword.Text;

            if (txtauthorname.Text == "")
            {
                MessageBox.Show("Please Fill Author Name", "Author Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthorname.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Please Fill Email", "Author Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthorname.Focus();
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Please Fill User Name", "Author Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthorname.Focus();
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Please Fill Password", "Author Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthorname.Focus();
            }
            else
            {
                int data = authords.Insert(author.authorid, author.authorname, author.emailaddress, author.username, author.password);
                if (data > 0)
                {
                    authorname=txtauthorname.Text;
                    MessageBox.Show("Author Data has been Saved.");
                    txtauthorname.Text = "";
                    txtemail.Text = "";
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtauthorname.Focus();
                    AutoID();
                }
            }

        }

        private void Author_Load(object sender, EventArgs e)
        {
            AutoID();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
