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
    public partial class Comment : Form
    {
        PeerReviewDataSetTableAdapters.DocumentTableAdapter ds = new PeerReviewDataSetTableAdapters.DocumentTableAdapter();
        public static string did;

        public Comment()
        {
            InitializeComponent();
        }

        public void NewDataTable()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dr = dt.NewRow();
            dt.Columns.Add("DocumentID").ToString();
            dt.Columns.Add("DocumentName").ToString();
            dt.Columns.Add("ReviewerName").ToString();
            dt.Columns.Add("CommentDate").ToString();
            dt.Columns.Add("Comment").ToString();
            dgvDisplay.DataSource = dt;
        }
        public void selectDocument()
        {
            DataTable dt = new DataTable();
            dt = ds.GetData();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbocd.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }
        private void Comment_Load(object sender, EventArgs e)
        {
            NewDataTable();
            selectDocument();
            btnsearch.Visible = false;
            string aid = Login.authorid;
            DataTable dt = new DataTable();
            dt = ds.SearchAuthor(aid.ToString());
            dgvDisplay.DataSource = dt;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                String DName = cbocd.SelectedItem.ToString();
                try
                {
                    dgvDisplay.DataSource = ds.SearchDocument(DName.ToString(), Login.authorid);
                }
                catch
                {
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DetailComment dc = new DetailComment();
            dc.ShowDialog();
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsearch.Visible = true;
            btnShow.Visible = false;
            did = dgvDisplay.Rows[dgvDisplay.CurrentRow.Index].Cells[0].Value.ToString();
        }
    }
}
