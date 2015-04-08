using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Worker : Persistable
    {
        /// <summary>
        /// instance variables/ table columns
        /// </summary>
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }

        private string _bannerid;
        public string BannerID { get { return _bannerid; } set { _bannerid = value; } }

        private string _fn;
        public string FirstName { get { return _fn; } set { _fn = value; } }

        private string _ln;
        public string LastName { get { return _ln; } set { _ln = value; } }

        private string phone_number;
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }

        private string email_address;
        public string EmailAddress { get { return email_address; } set { email_address = value; } }

        private string _credential;
        public string Credential { get { return _credential; } set { _credential = value; } }

        private string init_reg_date;
        public string InitialRegistrationDate { get { return init_reg_date; } set { init_reg_date = value; } }

        private string worker_password;
        public string WorkerPassword { get { return worker_password; } set { worker_password = value; } }

        private string _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }

        private string _status;
        public string Status { get { return _status; } set { _status = value; } }

        private string date_status_updated;
        public string DateStatusUpdated { get { return date_status_updated; } set { date_status_updated = value; } }

         public Worker()
            : base() // call parent default constructor
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Katie\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\bicycle-rental\BicycleRentalCLI\bin\Debug" +
                @"\BicycleRental.accdb";
        }
        
        public Worker(string bid, string f, string l, string pn, string em, string c, string ird,
            string wpwd, string note, string st, string dstu) : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Katie\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\bicycle-rental\BicycleRentalCLI\bin\Debug" +
                @"\BicycleRental.accdb";
            this.BannerID = bid;
            this.FirstName = f;
            this.LastName = l;
            this.PhoneNumber = pn;
            this.EmailAddress = em;
            this.Credential = c;
            this.InitialRegistrationDate = ird;
            this.WorkerPassword = wpwd;
            this.Notes = note;
            this.Status = st;
            this.DateStatusUpdated = dstu;
        }

        public void populate(int ID)
        {
            string queryString = "SELECT * FROM Worker WHERE (ID = " + ID + ")";
            List<Object[]> results = getValues(queryString);
            if (results != null)
            {
                foreach (Object[] result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    foreach (Object rowValue in row)
                    {
                        // DEBUG Console.WriteLine(rowValue);
                        if (count == 0)
                            this.ID = Convert.ToInt32(rowValue);
                        else if (count == 1)
                            BannerID = Convert.ToString(rowValue);
                        else if (count == 2)
                            FirstName = Convert.ToString(rowValue);
                        else if (count == 3)
                            LastName = Convert.ToString(rowValue);
                        else if (count == 4)
                            PhoneNumber = Convert.ToString(rowValue);
                        else if (count == 5)
                            EmailAddress = Convert.ToString(rowValue);
                        else if (count == 6)
                            Credential = Convert.ToString(rowValue);
                        else if (count == 7)
                            InitialRegistrationDate = Convert.ToString(rowValue);
                        else if (count == 8)
                            WorkerPassword = Convert.ToString(rowValue);
                        else if (count == 9)
                            Notes = Convert.ToString(rowValue);
                        else if (count == 10)
                            Status = Convert.ToString(rowValue);
                        else if (count == 11)
                            DateStatusUpdated = Convert.ToString(rowValue);

                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void insert()
        {

            string insertQuery =
            "INSERT INTO Worker (BannerID, FirstName, LastName, PhoneNumber, EmailAddress, Credential, InitialRegistrationDate, WorkerPassword, Notes, Status, DateStatusUpdated) " +
            "VALUES (" +
            "'" + this.BannerID + "', '" +
            this.FirstName + "', '" +
            this.LastName + "', '" +
            this.PhoneNumber + "', '" +
            this.EmailAddress + "', '" +
            this.Credential + "', '" +
            this.InitialRegistrationDate + "', '" +
            this.WorkerPassword + "', '" +
            this.Notes + "', '" +
            this.Status + "', '" +
            this.DateStatusUpdated + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Worker object into database");
            }
            else
            {
                Console.WriteLine("Worker object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Worker";
                List<Object[]> results = getValues(idQueryString);
                if (results != null)
                {

                    // DEBUG Console.WriteLine("Got an id from id query");
                    foreach (Object[] result in results)
                    {
                        IEnumerable<Object> row = result as IEnumerable<Object>;
                        foreach (Object rowValue in row)
                        {
                            // DEBUG Console.WriteLine("Retrieved id = " + rowValue);
                            this.ID = Convert.ToInt32(rowValue);
                        }
                    }

                }
            }
        }
        //------------------------------------------------------------------
        public void update()
        {
            string updateQuery = "UPDATE Worker SET " +
                " BannerID = '" + this.BannerID + "' ," +
                " FirstName = '" + this.FirstName + "' ," +
                " LastName = '" + this.LastName + "' ," +
                " PhoneNumber = '" + this.PhoneNumber + "' ," +
                " EmailAddress = '" + this.EmailAddress + "', " +
                " Credential = '" + this.Credential + "', " +
                " InitialRegistrationDate = '" + this.InitialRegistrationDate + "', " +
                " WorkerPassword = '" + this.WorkerPassword + "', " +
                " Notes = '" + this.Notes + "', " +
                " Status = '" + this.Status + "', " +
                " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
                " WHERE " +
                " ID = " + this.ID;
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Worker object into database");
            else
                Console.WriteLine("Worker object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM Worker WHERE " +
                " ID = " + this.ID;
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Worker object from database");
            else
                Console.WriteLine("Worker object successfully deleted");
        }
        //------------------------------------------------------------------



    }
}

