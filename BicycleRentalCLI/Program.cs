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
            //VEHICLE CLASS TESTING
            Vehicle v = new Vehicle("Schwinn", "5813", "SCH58", "Red", "Classy", "Welcome Center", "New", "-", "Active", "2015-10-02");
            //.insert() test
            Console.WriteLine("Starting .insert() test for Vehicle class ------------------------");
            v.insert();
            Console.WriteLine("Ending .insert() test for Vehicle class --------------------------");
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
            //v.delete();  //<-- Uncomment this before testing
            Console.WriteLine("Ending .delete() test for Vehicle class --------------------------");
            //END OF VEHICLE CLASS TESTING


            //User u = new User(800111222, "Lenny", "John", "585-395-5151", "rich@poor.com", "Student", "My notes", "Active", "2015-01-30");
            //u.insert();

            Console.ReadLine();
        }
    }
}
