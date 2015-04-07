using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class User : Persistable
    {
        /// <summary>
        /// instance variables/ table columns
        /// </summary>
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }

        private int _bannerid;
        public int BannerID { get { return _bannerid; } set { _bannerid = value; } }

        private string _fn;
        public string FirstName { get { return _fn; } set { _fn = value; } }

        private string _ln;
        public string LastName { get { return _ln; } set { _ln = value; } }

        private string phone_number;
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }

        private string email_address;
        public string EmailAddress { get { return email_address; } set { email_address = value; } }

        private string user_type;
        public string UserType { get { return user_type; } set { user_type = value; } }

        private string _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }

        private string _status;
        public string Status { get { return _status; } set { _status = value; } }

        private string date_status_updated;
        public string DateStatusUpdated { get { return date_status_updated; } set { date_status_updated = value; } }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="auid">Auto Generated ID</param>
        /// <param name="bid">Banner ID</param>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="pn">Phone Number</param>
        /// <param name="em">Email</param>
        /// <param name="ut">User Type</param>
        /// <param name="note">Notes</param>
        /// <param name="st">Status</param>
        /// <param name="dstu">Date Status Updated</param>
        public User(int auid, int bid, string f, string l, string pn, string em, string ut,
            string note, string st, string dstu)
        {
            this.ID = auid;
            this.BannerID = bid;
            this.FirstName = f;
            this.LastName = l;
            this.PhoneNumber = pn;
            this.EmailAddress = em;
            this.UserType = ut;
            this.Notes = note;
            this.Status = st;
            this.DateStatusUpdated = dstu;
        }
    }
}
