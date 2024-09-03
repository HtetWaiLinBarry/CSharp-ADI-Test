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
    public partial class ReviewRating : Form
    {
        public static string rid;
        PeerReviewDataSetTableAdapters.RatingTableAdapter rd = new PeerReviewDataSetTableAdapters.RatingTableAdapter();

        public ReviewRating()
        {
            InitializeComponent();
        }

        private void txtdn_TextChanged(object sender, EventArgs e)
        {

        }
        public void NewDataTable()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dr = dt.NewRow();
            dt.Columns.Add("DocumentName").ToString();
            dt.Columns.Add("CommentID").ToString();
            dt.Columns.Add("RatingID").ToString();
            dt.Columns.Add("RatingNo").ToString();
            dt.Columns.Add("DocumentID").ToString();
            dgvdisplay.DataSource = dt;
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
           }

        private void dgvdisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rid = dgvdisplay.Rows[dgvdisplay.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            }

        private void ReviewRating_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = rd.GetData();
            dgvdisplay.DataSource = dt;
       
        }
    }
}
