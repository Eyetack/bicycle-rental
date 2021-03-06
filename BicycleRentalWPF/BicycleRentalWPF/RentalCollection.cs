﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programmers: Katie Littlefield and Lior Shahverdi
namespace BicycleRentalWPF
{
    class RentalCollection : Persistable
    {
        private List<Rental> rentalsOut;
        public List<Rental> RentalsOut { get { return rentalsOut; } }


        public RentalCollection()
            : base() // call parent default constructor
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                @"\BicycleRental.accdb";

            rentalsOut = new List<Rental>();
        }

        /// <summary>
        /// populates this RentalCollection object with Rental entries from the Rental table in our .accdb file
        /// </summary>
        public void populateWithRentedOutBikes()
        {
            string queryString = "SELECT ID FROM Rental WHERE (DateReturned = " + "' '" +  ")";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (Object[] result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;

                    int nextRentalID = (int)row.ElementAt(0);
                    Rental nr = new Rental();
                    nr.populate(nextRentalID);
                    rentalsOut.Add(nr);
                }
            }
            Console.WriteLine("Size of Collection ->" + rentalsOut.Count);
        }

        public Rental getRental(int id)
        {
            String queryString = "SELECT * FROM [Rental] WHERE (VehicleID = " + id + ") AND (CheckinWorkerID = 0)";
            List<Object> results = getValues(queryString);
            Rental nr = new Rental();
            if (results != null)
            {
                foreach (Object[] result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;

                    int nextRentalID = (int)row.ElementAt(0);
                    nr.populate(nextRentalID);
                }

                return nr;
            }

            else return nr;
        }

        /// <summary>
        /// toString function for RentalCollection for output
        /// </summary>
        public override string ToString()
        {
            string temp = "";
            foreach (Rental r in rentalsOut)
            {
                temp += r.ToString();
            }
            return temp;
        }
    }
}

