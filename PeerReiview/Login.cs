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
    public partial class Login : Form
    {
        PeerReviewDataSetTableAdapters.AuthorTableAdapter ads = new PeerReviewDataSetTableAdapters.AuthorTableAdapter();
        public static String authorid, authorname;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Author a = new Author();
            a.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Enter User Name", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {

                dt = ads.ForAuthor(txtUserName.Text, txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    authorid = dt.Rows[0][0].ToString();
                    authorname = dt.Rows[0][1].ToString();
                    MessageBox.Show("Login Successful", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main D = new Main();
                    D.ShowDialog();
                    this.Hide();
                }
            }
        }

       

    }
}
