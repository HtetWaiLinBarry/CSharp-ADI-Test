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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            PeerReview pr = new PeerReview();
            pr.ShowDialog();
        }

        private void mnuReviewer_Click(object sender, EventArgs e)
        {
            frmreviewer r = new frmreviewer();
            r.ShowDialog();
        }
    }
}
