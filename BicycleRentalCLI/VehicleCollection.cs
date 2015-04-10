using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class VehicleCollection : Persistable
    {
        public List<Vehicle> bikes;
        
        public VehicleCollection() : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                @"\BicycleRental.accdb";
            this.bikes = new List<Vehicle>();
            populateWithGoodAndActiveBikes();
        }

        public void populateWithGoodAndActiveBikes()
        {
            string queryString = "SELECT * FROM Vehicle WHERE (PhysicalCondition = 'Good') AND (Status = 'Active')";
            List<Object> results = getValues(queryString);
            if (results != null)
            {
                foreach (object result in results)
                {
                    IEnumerable<Object> row = result as IEnumerable<Object>;
                    Vehicle nv = new Vehicle();
                    int count = 0;
                    foreach (object rowValue in row)
                    {
                        //DEBUG Console.WriteLine(rowValue);
                        if (count == 0) nv.ID = Convert.ToInt32(rowValue);
                        else if (count == 1) nv.BikeMake = Convert.ToString(rowValue);
                        else if (count == 2) nv.ModelNumber = Convert.ToString(rowValue);
                        else if (count == 3) nv.SerialNumber = Convert.ToString(rowValue);
                        else if (count == 4) nv.Color = Convert.ToString(rowValue);
                        else if (count == 5) nv.Description = Convert.ToString(rowValue);
                        else if (count == 6) nv.Location = Convert.ToString(rowValue);
                        else if (count == 7) nv.PhysicalCondition = Convert.ToString(rowValue);
                        else if (count == 8) nv.Notes = Convert.ToString(rowValue);
                        else if (count == 9) nv.Status = Convert.ToString(rowValue);
                        else if (count == 10) nv.DateStatusUpdated = Convert.ToString(rowValue);
                        count++;
                    }
                    bikes.Add(nv);
                }
            }
            Console.WriteLine("Size of Collection ->" + bikes.Count);
        }
    }
}
