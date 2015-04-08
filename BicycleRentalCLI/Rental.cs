using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Rental : Persistable
    {
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }

        private int _vehicleid;
        public int VehicleID { get { return _vehicleid; } set { _vehicleid = value; } }

        private int _renterid;
        public int RenterID { get { return _renterid; } set { _renterid = value; } }

        private string _daterented;
        public string DateRented { get { return _daterented; } set { _daterented = value; } }

        private string _timerented;
        public string TimeRented { get { return _timerented; } set { _timerented = value; } }

        private string date_due;
        public string DateDue { get { return date_due; } set { date_due = value; } }

        private string time_due;
        public string TimeDue { get { return time_due; } set { time_due = value; } }

        private string date_returned;
        public string DateReturned { get { return date_returned; } set { date_returned = value; } }

        private string time_returned;
        public string TimeReturned { get { return time_returned; } set { time_returned = value; } }

        private int _checkout;
        public int CheckoutWorkerID { get { return _checkout; } set { _checkout = value; } }

        private int _checkin;
        public int CheckInWorkerID { get { return _checkin; } set { _checkin = value; } }

         public Rental()
            : base() // call parent default constructor
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Katie\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\bicycle-rental\BicycleRentalCLI\bin\Debug" +
                @"\BicycleRental.accdb";
        }
        
        public Rental(int vid, int rid, string drent, string trent, string dd, string td, string dreturn, string treturn, int checkin, int checkout) : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Katie\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\bicycle-rental\BicycleRentalCLI\bin\Debug" +
                @"\BicycleRental.accdb";
            this.VehicleID = vid;
            this.RenterID = rid;
            this.DateRented = drent;
            this.TimeRented = trent;
            this.DateDue = dd;
            this.TimeDue = td;
            this.DateReturned = dreturn;
            this.TimeReturned = treturn;
            this.CheckInWorkerID = checkin;
            this.CheckoutWorkerID = checkout;
            
        }

        public void populate(int ID)
        {
            string queryString = "SELECT * FROM Rental WHERE (ID = " + ID + ")";
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
                            VehicleID = Convert.ToInt32(rowValue);
                        else if (count == 2)
                            RenterID = Convert.ToInt32(rowValue);
                        else if (count == 3)
                            DateRented = Convert.ToString(rowValue);
                        else if (count == 4)
                            TimeRented = Convert.ToString(rowValue);
                        else if (count == 5)
                            DateDue = Convert.ToString(rowValue);
                        else if (count == 6)
                            TimeDue = Convert.ToString(rowValue);
                        else if (count == 7)
                            DateReturned = Convert.ToString(rowValue);
                        else if (count == 8)
                            TimeReturned = Convert.ToString(rowValue);
                        else if (count == 9)
                            CheckoutWorkerID = Convert.ToInt32(rowValue);
                        else if (count == 10)
                            CheckInWorkerID = Convert.ToInt32(rowValue);

                        count = count + 1;
                    }
                }
            }
        }
        //------------------------------------------------------------------
        public void insert()
        {

            string insertQuery =
            "INSERT INTO Rental (VehicleID, RenterID, DateRented, TimeRented, DateDue, TimeDue, DateReturned, TimeReturned, CheckoutWorkerID, CheckInWorkerID) " +
            "VALUES (" +
            "'" + this.VehicleID + "', '" +
            this.RenterID + "', '" +
            this.DateRented + "', '" +
            this.TimeRented + "', '" +
            this.DateDue + "', '" +
            this.TimeDue + "', '" +
            this.DateReturned + "', '" +
            this.TimeReturned + "', '" +
            this.CheckoutWorkerID + "', '" +
            this.CheckInWorkerID + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0)
            {
                Console.WriteLine("Error in inserting Rental object into database");
            }
            else
            {
                Console.WriteLine("Rental object successfully inserted");
                string idQueryString = "SELECT MAX(ID) FROM Rental";
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
            string updateQuery = "UPDATE Rental SET " +
                " VehicleID = '" + this.VehicleID + "' ," +
                " RenterID = '" + this.RenterID + "' ," +
                " DateRented = '" + this.DateRented + "' ," +
                " TimeRented = '" + this.TimeRented + "' ," +
                " DateDue = '" + this.DateDue + "', " +
                " TimeDue = '" + this.TimeDue + "', " +
                " DateReturned = '" + this.DateReturned + "', " +
                " TimeReturned = '" + this.TimeReturned + "', " +
                " CheckoutWorkerID = '" + this.CheckoutWorkerID + "', " +
                " CheckInWorkerID = '" + this.CheckInWorkerID + "' " +
                " WHERE " +
                " ID = " + this.ID;
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in updating Rental object into database");
            else
                Console.WriteLine("Rental object successfully updated");
        }
        //------------------------------------------------------------------
        public void delete()
        {
            string deleteQuery = "DELETE FROM Rental WHERE " +
                " ID = " + this.ID;
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0)
                Console.WriteLine("Error in deleting Rental object from database");
            else
                Console.WriteLine("Rental object successfully deleted");
        }
        //------------------------------------------------------------------

    }
}
