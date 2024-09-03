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
    public partial class DetailComment : Form
    {
        PeerReviewDataSetTableAdapters.CommentTableAdapter cds = new PeerReviewDataSetTableAdapters.CommentTableAdapter();
        public static String did;
        public DetailComment()
        {
            InitializeComponent();
        }
        public void NewDataTable()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dr = dt.NewRow();
            dt.Columns.Add("DocumentID").ToString();
            dt.Columns.Add("ReviewerID").ToString();
            dt.Columns.Add("DocumentName").ToString();
            dt.Columns.Add("UploadFile").ToString();
            dt.Columns.Add("UploadDate").ToString();
            dt.Columns.Add("AuthorID").ToString();
            dt.Columns.Add("Description").ToString();
            dgvcdisplay.DataSource = dt;
        }
        private void DetailComment_Load(object sender, EventArgs e)
        {
            string doid = Comment.did;
            DataTable dt = new DataTable();
            dt = cds.CheckComment(doid.ToString(), Login.authorid);
            if (dt.Rows.Count > 0)
            {
                dgvcdisplay.DataSource = dt;
            }
            else
            {
                NewDataTable();
            }

        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            did = dgvcdisplay.Rows[dgvcdisplay.CurrentRow.Index].Cells[0].Value.ToString();

            Rating ra = new Rating();
            ra.ShowDialog();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvcdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
