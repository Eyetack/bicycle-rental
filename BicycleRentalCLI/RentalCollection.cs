using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class RentalCollection : Persistable
    {
        private List<Rental> rentalsOut;


         public RentalCollection()
            : base() // call parent default constructor
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Katie\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\bicycle-rental\BicycleRentalCLI\bin\Debug" +
                @"\BicycleRental.accdb";

            rentalsOut = new List<Rental>();
        }

        /// <summary>
         /// populates this RentalCollection object with Rental entries from the Rental table in our .accdb file
        /// </summary>
        public void populateWithRentedOutBikes()
        {
            string queryString = "SELECT * FROM Rental WHERE (DateReturned = " + "' '" + ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (Object[] result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    int count = 0;
                    int ID = 0;
                    int VehicleID = 0;
                    int RenterID = 0;
                    string DateRented = "";
                    string TimeRented = "";
                    string DateDue = "";
                    string TimeDue = "";
                    string DateReturned = "";
                    string TimeReturned = "";
                    int CheckoutWorkerID = 0;
                    int CheckInWorkerID = 0;

                    foreach (Object rowValue in row)
                    {
                        // DEBUG Console.WriteLine(rowValue);
                        if (count == 0)
                             ID = Convert.ToInt32(rowValue);
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

                    Rental r = new Rental(VehicleID, RenterID, DateRented, TimeRented, DateDue, TimeDue, DateReturned, TimeReturned, CheckInWorkerID, CheckoutWorkerID);
                    rentalsOut.Add(r);
                }
            }
        }

        /// <summary>
        /// toString function for RentalCollection for output
        /// </summary>
         public void toString()
        {
            foreach(Rental r in rentalsOut)
            {
                r.toString();
                Console.WriteLine("");
            }
        }
   }
  }

