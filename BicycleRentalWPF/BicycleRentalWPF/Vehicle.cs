using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programmers: Katie Littlefield and Lior Shahverdi
namespace BicycleRentalWPF
{
    public class Vehicle : Persistable
    {
        /// <summary>
        /// instance variables/properties of each Vehicle entry
        /// </summary>
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }

        private string bike_make;
        public string BikeMake { get { return bike_make; } set { bike_make = value; } }

        private string model_number;
        public string ModelNumber { get { return model_number; } set { model_number = value; } }

        private string serial_number;
        public string SerialNumber { get { return serial_number; } set { serial_number = value; } }

        private string _color;
        public string Color { get { return _color; } set { _color = value; } }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private string _location;
        public string Location { get { return _location; } set { _location = value; } }

        private string physical_condition;
        public string PhysicalCondition { get { return physical_condition; } set { physical_condition = value; } }

        private string _notes;
        public string Notes { get { return _notes; } set { _notes = value; } }

        private string _status;
        public string Status { get { return _status; } set { _status = value; } }

        private string date_status_updated;
        public string DateStatusUpdated { get { return date_status_updated; } set { date_status_updated = value; } }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="auid">ID</param>
        /// <param name="bm">Bike Make</param>
        /// <param name="mdnum">Model Number</param>
        /// <param name="sernum">Serial Number</param>
        /// <param name="color">Color</param>
        /// <param name="desc">Description</param>
        /// <param name="locn">Location</param>
        /// <param name="phy_cond">Physical Condition</param>
        /// <param name="note">Notes</param>
        /// <param name="st">Status</param>
        /// <param name="dstu">Date Status Updated</param>
        public Vehicle(string bm, string mdnum, string sernum, string color, string desc, string locn,
            string phy_cond, string note)
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                 @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                 @"\BicycleRental.accdb";
            this.BikeMake = bm;
            this.ModelNumber = mdnum;
            this.SerialNumber = sernum;
            this.Color = color;
            this.Description = desc;
            this.Location = locn;
            this.PhysicalCondition = phy_cond;
            this.Notes = note;
            this.Status = "Active";
            this.DateStatusUpdated = DateTime.Now.ToString("yyyy-MM-dd");
        }

        //default constructor
        public Vehicle()
            : base()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.15.0;" +
                @"Data source= C:\Users\Lior\Documents\Visual Studio 2013\Projects\BicycleRentalCLI\BicycleRentalCLI" +
                @"\BicycleRental.accdb";
        }

        /// <summary>
        /// Populates the Vehicle object with a Vehicle entry from the Vehicle table in our .accdb file
        /// </summary>
        /// <param name="id">Auto generated ID</param>
        public void populate(int id)
        {
            string queryString = "SELECT * FROM Vehicle WHERE (ID = " + id + ")";
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
                        else if (count == 1) this.BikeMake = Convert.ToString(rowValue);
                        else if (count == 2) this.ModelNumber = Convert.ToString(rowValue);
                        else if (count == 3) this.SerialNumber = Convert.ToString(rowValue);
                        else if (count == 4) this.Color = Convert.ToString(rowValue);
                        else if (count == 5) this.Description = Convert.ToString(rowValue);
                        else if (count == 6) this.Location = Convert.ToString(rowValue);
                        else if (count == 7) this.PhysicalCondition = Convert.ToString(rowValue);
                        else if (count == 8) this.Notes = Convert.ToString(rowValue);
                        else if (count == 9) this.Status = Convert.ToString(rowValue);
                        else if (count == 10) this.DateStatusUpdated = Convert.ToString(rowValue);
                        count = count + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Inserts an entry into the Vehicle table in our .accdb file
        /// </summary>
        public void insert()
        {
            string insertQuery =
                "INSERT INTO Vehicle (BikeMake, ModelNumber, SerialNumber, Color, Description, Location, PhysicalCondition, Notes, Status, DateStatusUpdated)" +
                "VALUES (" +
                "'" + this.BikeMake + "', '" +
                this.ModelNumber + "', '" +
                this.SerialNumber + "', '" +
                this.Color + "', '" +
                this.Description + "', '" +
                this.Location + "', '" +
                this.PhysicalCondition + "', '" +
                this.Notes + "', '" +
                this.Status + "', '" +
                this.DateStatusUpdated + "')";
            int returnCode = modifyDatabase(insertQuery);
            if (returnCode != 0) Console.WriteLine("Error in inserting Vehicle object into db!");
            else
            {
                Console.WriteLine("Vehicle object successfully created!");
                string idQueryString = "SELECT MAX(ID) FROM Vehicle";
                List<Object> results = getValues(idQueryString);
                if (results != null)
                {
                    //DEBUG 
                    Console.WriteLine("Got an id from id query");
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
        /// updates a single entry in the Vehicle table in our .accdb file
        /// </summary>
        public void update()
        {
            string updateQuery = "UPDATE Vehicle SET" +
                " BikeMake = '" + this.BikeMake + "', " +
                " ModelNumber ='" + this.ModelNumber + "', " +
                " SerialNumber ='" + this.SerialNumber + "', " +
                " Color = '" + this.Color + "', " +
                " Description ='" + this.Description + "', " +
                " Location = '" + this.Location + "', " +
                " PhysicalCondition = '" + this.PhysicalCondition + "' , " +
                " Notes ='" + this.Notes + "', " +
                " Status ='" + this.Status + "', " +
                " DateStatusUpdated = '" + this.DateStatusUpdated + "' " +
                " WHERE " +
                " ID = " + this.ID;
            //Console.WriteLine(updateQuery);
            int returnCode = modifyDatabase(updateQuery);
            if (returnCode != 0) Console.WriteLine("Error in updating Vehicle object in db.");
            else Console.WriteLine("Vehicle object successfully updated!");
        }

        public void delete()
        {
            string deleteQuery = "DELETE FROM Vehicle WHERE " +
                " ID = " + this.ID;
            //Console.WriteLine(deleteQuery);
            int returnCode = modifyDatabase(deleteQuery);
            if (returnCode != 0) Console.WriteLine("Error in deleting Vehicle object in db.");
            else Console.WriteLine("Vehicle object successfully deleted!");
        }

        public override string ToString()
        {
            return "ID=" + this.ID + " BikeMake=" + this.BikeMake + " ModelNumber=" + this.ModelNumber +
                " SerialNumber=" + this.SerialNumber + " Color=" + this.Color + " Description=" + this.Description +
                " Location=" + this.Location + " PhysicalCondition=" + this.PhysicalCondition + " Notes=" + this.Notes +
                " Status=" + this.Status + " DateStatusUpdated=" + this.DateStatusUpdated;
        }
    }
}
