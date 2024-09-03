using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PeerReiview
{
    public partial class Document : Form
    {
        PeerReviewDataSetTableAdapters.DocumentTableAdapter docds = new PeerReviewDataSetTableAdapters.DocumentTableAdapter();
        PeerReviewDataSetTableAdapters.AuthorTableAdapter ads = new PeerReviewDataSetTableAdapters.AuthorTableAdapter();
      

        public Document()
        {
            InitializeComponent();
        }
        public void AutoID()
        {
            DataTable dt = new DataTable();
            dt = docds.GetData();
            if (dt.Rows.Count == 0)
            {
                txtDocumentID.Text = "D_001";
            }
            else
            {
                int size = dt.Rows.Count - 1;

                String oldid = dt.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtDocumentID.Text = "D_00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtDocumentID.Text = "D_0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtDocumentID.Text = "D_" + (newid + 1);
                }
            }
        }

        private void Document_Load(object sender, EventArgs e)
        {
            AutoID();
            //txtDocumentID.Text = docds.CheckDocID(Login.authorid);

            lblUploadDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblAuthorName.Text = Login.authorname;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofd.Filter = "pdf files(*.pdf)|*.pdf;";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string FileName = ofd.FileName;

                FileInfo fi = new FileInfo(FileName);
                txtUploadFile.Text = fi.Name;
                txtUploadFile.Enabled = false;
                viewfile.LoadFile(ofd.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDocument doc = new clsDocument();
            doc.docid = txtDocumentID.Text;
            doc.docname = txtDocumentName.Text;
            doc.authorid = Login.authorid;
            doc.description = txtDescription.Text;
            doc.uploaddate = txtUploadFile.Text;
            

            if(txtDocumentName.Text=="")
            {
                MessageBox.Show("Please Enter Document Name","Document Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentName.Focus();
            }
            else if(txtUploadFile.Text=="")
            {
                MessageBox.Show("Please Upload File","Document Entry",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtDescription.Text == "")
            { 
                MessageBox.Show("Plase Enter Description", "Document Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
            }
            else
            {
                int count = docds.Insert(doc.docid, doc.docname, txtUploadFile.Text, doc.uploaddate, doc.authorid, doc.description);
                if(count>0)
                {
                    MessageBox.Show("Document Save Successful", "Document Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDocumentName.Clear();
                    txtDocumentName.Text = "";
                    txtUploadFile.Text = "";
                    txtDescription.Text = "";
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void viewfile_OnError(object sender, EventArgs e)
        {

        }
    }

 }
    

