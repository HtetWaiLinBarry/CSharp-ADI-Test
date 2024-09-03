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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

        private void mnuDocument_Click(object sender, EventArgs e)
        {
            Document d = new Document();
            d.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void mnuSearchDocument_Click(object sender, EventArgs e)
        {
            DocumentList DL = new DocumentList();
            DL.Show();
        }

        private void searchCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comment C = new Comment();
            C.Show();
        }

        private void searchRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewRating C = new ReviewRating();
            C.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerReviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreviewer fr = new frmreviewer();
            fr.Show();
            this.Hide();
        }
        }
    }

