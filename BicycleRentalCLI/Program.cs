using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRentalCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("800490178", "Katie", "Littlefield", "585-555-5555", "kl@gmail.com", "Admin", "2015-04-07", "apple", "Good Worker");
            w.insert();
            w.populate(1);
            w.toString();
            w.Status = "Invalid";
            w.update();
            //w.delete();

            Rental r = new Rental(1, 1, "2015-04-07", "1:30", "2015-04-14", "1:30", "", "", 0, 2);
            r.insert();
            r.populate(3);
            r.toString();
            r.DateDue = "2015-04-20";
            r.update();
            //r.delete();

            RentalCollection rc = new RentalCollection();
            rc.populateWithRentedOutBikes();
            rc.toString();
        }
    }
}
