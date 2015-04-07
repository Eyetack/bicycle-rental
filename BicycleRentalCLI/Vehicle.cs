using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Vehicle : Persistable
    {
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
        public Vehicle(int auid, string bm, string mdnum, string sernum, string color, string desc, string locn,
            string phy_cond, string note, string st, string dstu)
        {
            this.ID = auid;
            this.BikeMake = bm;
            this.ModelNumber = mdnum;
            this.SerialNumber = sernum;
            this.Color = color;
            this.Description = desc;
            this.Location = locn;
            this.PhysicalCondition = phy_cond;
            this.Notes = note;
            this.Status = st;
            this.DateStatusUpdated = dstu;
        }
    }
}
