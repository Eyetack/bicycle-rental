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
            Worker w = new Worker("800490178", "Katie", "Littlefield", "585-555-5555", "kl@gmail.com", "Admin", "2015-04-07", "apple", "Good Worker", "Valid", "2015-04-07");
            w.insert();
            w.populate(4);
            Console.WriteLine(w.BannerID);
            Console.WriteLine(w.FirstName);
            Console.WriteLine(w.LastName);
            Console.WriteLine(w.PhoneNumber);
            Console.WriteLine(w.EmailAddress);
            Console.WriteLine(w.Credential);
            Console.WriteLine(w.InitialRegistrationDate);
            Console.WriteLine(w.WorkerPassword);
            Console.WriteLine(w.Notes);
            Console.WriteLine(w.Status);
            Console.WriteLine(w.DateStatusUpdated);
            w.Status = "Invalid";
            w.update();
            w.delete();

            Rental r = new Rental(1, 1, "2015-04-07", "1:30", "2015-04-14", "1:30", "", "", 0, 2);
            r.insert();
            r.populate(1);
            Console.WriteLine(r.VehicleID);
            Console.WriteLine(r.RenterID);
            Console.WriteLine(r.DateRented);
            Console.WriteLine(r.TimeRented);
            Console.WriteLine(r.DateDue);
            Console.WriteLine(r.TimeDue);
            Console.WriteLine(r.DateReturned);
            Console.WriteLine(r.TimeReturned);
            Console.WriteLine(r.CheckoutWorkerID);
            Console.WriteLine(r.CheckInWorkerID);
            r.DateDue = "2015-04-20";
            r.update();
            r.delete();
        }
    }
}
