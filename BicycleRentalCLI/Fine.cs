using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
