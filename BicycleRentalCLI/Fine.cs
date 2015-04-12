using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmers: Katie Littlefield and Lior Shahverdi
namespace BicycleRentalCLI
{
    public class Fine : Persistable
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int borrower_id;
        public int BorrowerID
        {
            get { return borrower_id; }
            set { borrower_id = value; }
        }

        private double fine_amount;
        public double FineAmount
        {
            get { return fine_amount; }
            set { fine_amount = value; }
        }

        private string date_fine_imposed;
        public string DateFineImposed
        {
            get { return date_fine_imposed; }
            set { date_fine_imposed = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string date_status_updated;
        public string DateStatusUpdated
        {
            get { return date_status_updated; }
            set { date_status_updated = value; }
        }

        public Fine(int id, int bid, double fa, string dfi, string stat, string dsu)
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                 @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                 @"\BicycleRental.accdb";
            this.ID = id;
            this.BorrowerID = bid;
            this.FineAmount = fa;
            this.DateFineImposed = dfi;
            this.Status = stat;
            this.DateStatusUpdated = dsu;
        }

        //default constructor
        public Fine() : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                @"\BicycleRental.accdb";
        }

        /// <summary>
        /// retrieves all the Fine entries from the Vehicle table in our .accdb file
        /// </summary>
        /// <param name="id">Auto generated ID</param>
        public void populate(int id)
        {
            string queryString = "SELECT * FROM Fine WHERE (ID = " + id + ")";
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
                        else if (count == 1) this.BorrowerID = Convert.ToInt32(rowValue);
                        else if (count == 2) this.FineAmount = Convert.ToDouble(rowValue);
                        else if (count == 3) this.DateFineImposed = Convert.ToString(rowValue);
                        else if (count == 4) this.Status = Convert.ToString(rowValue);
                        else if (count == 5) this.DateStatusUpdated = Convert.ToString(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts an entry into the Fine table in our .accdb file
        /// </summary>
        public void insert()
        {
            string insertQuery =
                "INSERT INTO Fine (BorrowerID, FineAmount, DateFineImposed, Status, DateStatusUpdated)" +
                "VALUES (" +
                "'" + this.BorrowerID + "', '" +
                this.FineAmount + "', '" +
                this.DateFineImposed + "', '" +
                this.Status + "', '" +
                this.DateStatusUpdated + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0) Console.WriteLine("Error in inserting Fine object into db!");
            else
            {
                Console.WriteLine("Fine object successfully created!");
                string idQueryString = "SELECT MAX(ID) FROM Fine";
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
            string updateQuery = "UPDATE Fine SET " +
                " BorrowerID = '" + this.BorrowerID + "' , " +
                " FineAmount = '" + this.FineAmount + "' , " +
                " DateFineImposed = '" + this.DateFineImposed + "' , " +
                " Status = '" + this.Status + "' , " +
                " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
                " WHERE " +
                " ID = " + this.ID;
            //Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0) Console.WriteLine("Error in updating Fine object in db.");
            else Console.WriteLine("Fine object successfully updated!");
        }

        /// <summary>
        /// deletes a single entry in the User table in our .accdb file. 
        /// </summary>
        public void delete()
        {
            string deleteQuery = "DELETE FROM Fine WHERE " +
                " ID = " + this.ID;
            //Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0) Console.WriteLine("Error in deleting Fine object in db.");
            else Console.WriteLine("Fine object successfully deleted!");
        }
    }
}
