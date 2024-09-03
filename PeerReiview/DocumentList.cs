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
    public partial class DocumentList : Form
    {
        public static string docfile;
        public static string rname, docid;
        PeerReviewDataSetTableAdapters.DocumentTableAdapter dta = new PeerReviewDataSetTableAdapters.DocumentTableAdapter();

        public DocumentList()
        {
            InitializeComponent();
        }

        private void DocumentList_Load(object sender, EventArgs e)
        {
            btncomment.Visible = false;
            DataTable dt = new DataTable();
            dt = dta.GetData();
            dgvdisplay.DataSource = dt;
            rname = frmreviewer.reviewername;
        }
        public void NewDataTable()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dr = dt.NewRow();
            dt.Columns.Add("DocumentID").ToString();
            dt.Columns.Add("DocumentName").ToString();
            dt.Columns.Add("UploadFile").ToString();
            dt.Columns.Add("UploadDate").ToString();
            dt.Columns.Add("AuthorID").ToString();
            dt.Columns.Add("Description").ToString();
            dgvdisplay.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String DocumentName = txtdn.Text;
            dt = dta.SearchDocumentName(txtdn.Text);
            if (dt.Rows.Count > 0)
            {
                dgvdisplay.DataSource = dt;
            }
            else
            {
                NewDataTable();
            }
        }

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = false;
            btncomment.Visible = true;
            docid = dgvdisplay.Rows[dgvdisplay.CurrentRow.Index].Cells[0].Value.ToString();
        }

        private void btncomment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preview p = new Preview();
            p.ShowDialog();
        }

        private void txtdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
