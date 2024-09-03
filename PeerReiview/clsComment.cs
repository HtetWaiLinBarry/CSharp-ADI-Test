using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReiview
{
    class clsComment
    {
        String CommentID, ReviewerID, DocumentID, Description, CommentDate;

        public String commentdate
        {
            get { return CommentDate; }
            set { CommentDate = value; }
        }

        public String description
        {
            get { return Description; }
            set { Description = value; }
        }

        public String documentid
        {
            get { return DocumentID; }
            set { DocumentID = value; }
        }

        public String reviewerid
        {
            get { return ReviewerID; }
            set { ReviewerID = value; }
        }

        public String commentid
        {
            get { return CommentID; }
            set { CommentID = value; }
        }
    }
}
