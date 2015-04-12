using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmers: Katie Littlefield and Lior Shahverdi

namespace BicycleRentalCLI
{
    class Program
    {
        static void Main(string[] args)
        {

            //<VehicleTesting>
            Vehicle v = new Vehicle("Schwinn", "5813", "SCH58", "Red", "Classy", "Welcome Center", "Good", "-");
            Vehicle v1 = new Vehicle("Huffy", "7878", "H78A8", "Blue", "Dark", "Seymour Union", "Okay", "-"); 
            //.insert() test
            Console.WriteLine("Starting .insert() test for Vehicle class ------------------------");
            v.insert();
            v1.insert();
            Console.WriteLine("Ending .insert() test for Vehicle class --------------------------");
            //.populate() test
            Console.WriteLine("Starting .populate() test for Vehicle class ------------------------");
            v.populate(1);
            Console.WriteLine("Ending .populate() test for Vehicle class --------------------------");
            Console.WriteLine("Bike Make: "+v.BikeMake);
            Console.WriteLine("Model Number: "+v.ModelNumber);
            Console.WriteLine("Serial Number: "+v.SerialNumber);
            Console.WriteLine("Color: "+v.Color);
            Console.WriteLine("Description: "+v.Description);
            Console.WriteLine("Location: "+v.Location);
            Console.WriteLine("Physical Condition: "+v.PhysicalCondition);
            Console.WriteLine("Notes: "+v.Notes);
            Console.WriteLine("Status: "+v.Status);
            Console.WriteLine("DateStatusUpdated: "+v.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for Vehicle class ------------------------");
            v.Notes = "What a challenger, wow.";
            v.update();
            Console.WriteLine("Ending .update() test for Vehicle class --------------------------");
            //.delete() test
            Console.WriteLine("Starting .delete() test for Vehicle class ------------------------");
            v.delete();  //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for Vehicle class --------------------------\n\n");
            //</VehicleTesting>

            //<UserTesting>
            //(int bid, string f, string l, string pn, string em, string ut, string note, string st, string dstu)
            User u = new User(800111222, "Lenny", "John", "585-395-5151", "rich@poor.com", "Student", "My notes");
            //.insert() test
            Console.WriteLine("Starting .insert() test for User class");
            u.insert();
            Console.WriteLine("Ending .insert() test for User class");
            //.populate() test
            Console.WriteLine("Starting .populate() test for User class");
            u.populate(2);
            Console.WriteLine("Ending .populate() test for User class");
            Console.WriteLine("BannerID: " + u.BannerID);
            Console.WriteLine("FirstName: " + u.FirstName);
            Console.WriteLine("LastName: " + u.LastName);
            Console.WriteLine("PhoneNumber: " + u.PhoneNumber);
            Console.WriteLine("EmailAddress: " + u.EmailAddress);
            Console.WriteLine("UserType: " + u.UserType);
            Console.WriteLine("Notes: " + u.Notes);
            Console.WriteLine("Status: " + u.Status);
            Console.WriteLine("DateStatusUpdated: " + u.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for User class");
            u.EmailAddress = "newemail@email.com";
            u.update();
            Console.WriteLine("Ending .update() test for User class");
            //.delete() test
            Console.WriteLine("Starting .delete() test for User Class");
            u.delete(); //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for User Class\n\n");
            //</UserTesting>

            //<FineTesting>
            //(int id, int bid, double fa, string dfi, string stat, string dsu)
            Fine f = new Fine(1, 800112358, 5.50, "2015-02-30", "Active", "2015-03-02");
            //.insert() test
            Console.WriteLine("Starting .insert() test for Fine class");
            f.insert();
            Console.WriteLine("Ending .insert() test for Fine class");
            //.populate() test
            Console.WriteLine("Starting .populate() test for Fine class");
            f.populate(1);
            Console.WriteLine("Ending .populate() test for Fine class");
            Console.WriteLine("BorrowerID: " + f.BorrowerID);
            Console.WriteLine("FineAmount: " + f.FineAmount);
            Console.WriteLine("DateFineImposed: " + f.DateFineImposed);
            Console.WriteLine("Status: " + u.Status);
            Console.WriteLine("DateStatusUpdated: " + u.DateStatusUpdated);
            //.update() test
            Console.WriteLine("Starting .update() test for Fine class");
            f.FineAmount = 6.75;
            f.update();
            Console.WriteLine("Ending .update() test for Fine class");
            //.delete() test
            Console.WriteLine("Starting .delete() test for Fine Class");
            f.delete(); //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for Fine Class\n\n");
            //</FineTesting>*/

            //<VehicleCollectionTesting>
            Console.WriteLine("Starting test for VehicleCollection class");
            VehicleCollection vc = new VehicleCollection();
            Console.WriteLine("Ending test for VehicleCollection class\n\n");

            //<RentalTesting>
            Rental r = new Rental(1, 1, "2015-04-07", "1:30", "2015-04-14", "1:30", "", "", 0, 2);
            Console.WriteLine("Starting .insert() test for Rental class");
            r.insert();
            Console.WriteLine("Ending .insert() test for Rental class");
            Console.WriteLine("Starting .populate() test for Rental class");
            r.populate(1);
            Console.WriteLine("Ending .populate() test for Rental class");
            r.ToString();
            Console.WriteLine("Starting .update() test for Rental class");
            r.DateDue = "2015-04-20";
            r.update();
            Console.WriteLine("Ending .populate() test for Rental class");
            Console.WriteLine("Starting .delete() test for Rental class");
            r.delete();
            Console.WriteLine("Ending .delete() test for Rental class\n\n");
            //</RentalTesting>
            
            //<WorkerTesting>
            Worker w = new Worker("800490178", "Katie", "Littlefield", "585-555-5555", "kl@gmail.com", "Admin", "2015-04-07", "apple", "Good Worker");
            Console.WriteLine("Starting .insert() test for Worker class");
            w.insert();
            Console.WriteLine("Ending .insert() test for Worker class");
            Console.WriteLine("Starting .populate() test for Worker class");
            w.populate(1);
            Console.WriteLine("Ending .populate() test for Worker class");
            w.ToString();
            Console.WriteLine("Starting .update() test for Worker class");
            w.Status = "Invalid";
            w.update();
            Console.WriteLine("Ending .update() test for Worker class");
            Console.WriteLine("Starting .delete() test for Worker class");
            w.delete();
            Console.WriteLine("Ending .delete() test for Worker class\n\n");
            //</WorkerTesting>

            //<RentalCollectionTesting>
            RentalCollection rc = new RentalCollection();
            Console.WriteLine("Starting test for RentalCollection class");
            rc.populateWithRentedOutBikes();
            rc.ToString();
            Console.WriteLine("Ending test for VehicleCollection class");
            //</RentalCollectionTesting>

            Console.ReadLine();
        }
    }
}
//database provided by request.