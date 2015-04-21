using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmers: Katie Littlefield and Lior Shahverdi
namespace BicycleRentalCLI
{
    public class User : Persistable
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
        /// <param name="bid">Banner ID</param>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="pn">Phone Number</param>
        /// <param name="em">Email</param>
        /// <param name="ut">User Type</param>
        /// <param name="note">Notes</param>
        /// <param name="st">Status</param>
        /// <param name="dstu">Date Status Updated</param>
        public User(int bid, string f, string l, string pn, string em, string ut,
            string note)
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                 @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                 @"\BicycleRental.accdb";
            this.BannerID = bid;
            this.FirstName = f;
            this.LastName = l;
            this.PhoneNumber = pn;
            this.EmailAddress = em;
            this.UserType = ut;
            this.Notes = note;
            this.Status = "Active";
            this.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
        }

        //default constructor
        public User()
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                 @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                 @"\BicycleRental.accdb";
        }

        /// <summary>
        /// Populates the User object with a User entry from the User table in our .accdb file
        /// </summary>
        /// <param name="id">Auto generated ID</param>
        public void populate(int id)
        {
            string queryString = "SELECT * FROM [User] WHERE (ID = " + id + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        // DEBUG Console.WriteLine(rowValue);
                        if (count == 0) this.ID = Convert.ToInt32(rowValue);
                        else if (count == 1) this.BannerID = Convert.ToInt32(rowValue);
                        else if (count == 2) this.FirstName = Convert.ToString(rowValue);
                        else if (count == 3) this.LastName = Convert.ToString(rowValue);
                        else if (count == 4) this.PhoneNumber = Convert.ToString(rowValue);
                        else if (count == 5) this.EmailAddress = Convert.ToString(rowValue);
                        else if (count == 6) this.UserType = Convert.ToString(rowValue);
                        else if (count == 7) this.Notes = Convert.ToString(rowValue);
                        else if (count == 8) this.Status = Convert.ToString(rowValue);
                        else if (count == 9) this.DateStatusUpdated = Convert.ToString(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts an entry into the User table in our .accdb file
        /// </summary>
        public void insert()
        {
            string insertQuery =
                "INSERT INTO [User] (BannerID, FirstName, LastName, PhoneNumber, EmailAddress, UserType, Notes, Status, DateStatusUpdated)" +
                "VALUES (" +
                "'" + this.BannerID + "', '" +
                this.FirstName + "', '" +
                this.LastName + "', '" +
                this.PhoneNumber + "', '" +
                this.EmailAddress + "', '" +
                this.UserType + "', '" +
                this.Notes + "', '" +
                this.Status + "', '" +
                this.DateStatusUpdated + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0) Console.WriteLine("Error in inserting User object into db!");
            else
            {
                Console.WriteLine("User object successfully created!");
                string idQueryString = "SELECT MAX(ID) FROM [User]";
                List<Object> results = getValues(idQueryString);
                if (results != null)
                {
                    // DEBUG Console.WriteLine("Got an id from id query");
                    foreach (object result in results)
                    {
                        IEnumerable<Object> row = result as IEnumerable<Object>;
                        foreach (object rowValue in row)
                        {
                            this.ID = Convert.ToInt32(rowValue);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// updates a single entry in the User table in our .accdb file
        /// </summary>
        public void update()
        {
            string updateQuery = "UPDATE [User] SET " +
                " BannerID = '" + this.BannerID + "', " +
                " FirstName = '" + this.FirstName + "', " +
                " LastName = '" + this.LastName + "', " +
                " PhoneNumber = '" + this.PhoneNumber + "', " +
                " EmailAddress = '" + this.EmailAddress + "', " +
                " UserType = '" + this.UserType + "', " +
                " Notes = '" + this.Notes + "', " +
                " Status = '" + this.Status + "', " +
                " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
                " WHERE " +
                " (ID = " + this.ID + ")";
            //Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0) Console.WriteLine("Error in updating User object in db.");
            else Console.WriteLine("User object successfully updated!");
        }

        /// <summary>
        /// deletes a single entry in the User table in our .accdb file. 
        /// </summary>
        public void delete()
        {
            string deleteQuery = "DELETE FROM [User] WHERE " +
                " ID = " + this.ID;
            //Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0) Console.WriteLine("Error in deleting User object in db.");
            else Console.WriteLine("User object successfully deleted!");
        }
    }
}
