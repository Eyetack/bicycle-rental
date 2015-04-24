using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programmers: Katie Littlefield and Lior Shahverdi
namespace BicycleRentalWPF
{
    class VehicleCollection : Persistable
    {
        public List<Vehicle> bikes;

        //parameterless constructor
        public VehicleCollection()
            : base()// call parent default constructor
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                @"\BicycleRental.accdb";
            this.bikes = new List<Vehicle>();
            populateWithGoodAndActiveBikes();
        }

        /// <summary>
        /// populates this VehicleCollection object with Vehicle entries from the Vehicle table in our .accdb file
        /// </summary>
        public void populateWithGoodAndActiveBikes()
        {
            string queryString = "SELECT * FROM Vehicle WHERE (PhysicalCondition = 'Good') AND (Status = 'Active')";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (Object[] result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;

                    int nextBikeID = (int)row.ElementAt(0);
                    Vehicle nv = new Vehicle();
                    nv.populate(nextBikeID);
                    bikes.Add(nv);
                }
            }
            Console.WriteLine("Size of Collection ->" + bikes.Count);
        }
    }
}
