using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReiview
{
    class clsDocument
    {
        String DocumentID, DocumentName, UploadDate, AuthorID, Description;

        public String description
        {
            get { return Description; }
            set { Description = value; }
        }

        public String authorid
        {
            get { return AuthorID; }
            set { AuthorID = value; }
        }

        public String uploaddate
        {
            get { return UploadDate; }
            set { UploadDate = value; }
        }

        public String docname
        {
            get { return DocumentName; }
            set { DocumentName = value; }
        }

        public String docid
        {
            get { return DocumentID; }
            set { DocumentID = value; }
        }
    }
}
