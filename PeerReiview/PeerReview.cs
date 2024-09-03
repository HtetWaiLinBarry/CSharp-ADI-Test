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
    public partial class PeerReview : Form
    {
        public PeerReview()
        {
            InitializeComponent();
        }

        private void btnReviewer_Click(object sender, EventArgs e)
        {
            Form1 mr = new Form1();
            mr.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }

        private void quit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    }
}
