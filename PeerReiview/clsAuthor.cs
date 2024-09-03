using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerReiview
{
    class clsAuthor
    {
        String AuthorID, AuthorName, EmailAddress, UserName, Password;

        public String password
        {
            get { return Password; }
            set { Password = value; }
        }

        public String username
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public String emailaddress
        {
            get { return EmailAddress; }
            set { EmailAddress = value; }
        }

        public String authorname
        {
            get { return AuthorName; }
            set { AuthorName = value; }
        }

        public String authorid
        {
            get { return AuthorID; }
            set { AuthorID = value; }
        }
    }
}
