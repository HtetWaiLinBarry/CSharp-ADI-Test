using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReiview
{
    class clsreviewer
    {
        String ReviewerID, ReviewerName, ReviewerDate, ReviewerSkill;

        public String reviewerskill
        {
            get { return ReviewerSkill; }
            set { ReviewerSkill = value; }
        }

        public String reviewerdate
        {
            get { return ReviewerDate; }
            set { ReviewerDate = value; }
        }

        public String reviewername
        {
            get { return ReviewerName; }
            set { ReviewerName = value; }
        }

        public String reviewerid
        {
            get { return ReviewerID; }
            set { ReviewerID = value; }
        }

    }
}
