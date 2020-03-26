using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2
{
    class Program
    {
        static AirlineCoordinator aCoord;

        public static void deleteFlight()
        {
            int id;
            Console.Clear();
            Console.WriteLine(aCoord.flightList());
            Console.Write("Please enter a flight id to delete:");
            id = Convert.ToInt32(Console.ReadLine());
            if (aCoord.deleteFlight(id))
            {
                Console.WriteLine("Flight with id {0} deleted..", id);
            }
            else
            {
                Console.WriteLine("Flight with id {0} was not found..", id);
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void deleteCustomer()
        {
            int id;
            Console.Clear();
            Console.WriteLine(aCoord.customerList());
            Console.Write("Please enter a customer id to delete:");
            id = Convert.ToInt32(Console.ReadLine());
            if (aCoord.deleteCustomer(id))
            {
                Console.WriteLine("Customer with id {0} deleted..", id);
            }
            else
            {
                Console.WriteLine("Customer with id {0} was not found..", id);
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void viewFlights()
        {
            Console.Clear();
            Console.WriteLine(aCoord.flightList());
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void viewCustomers()
        {
            Console.Clear();
            Console.WriteLine(aCoord.customerList());
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void addCustomer()
        {
            string fname, lname, phone;

            Console.Clear();
            Console.WriteLine("-----------Add Customer----------");
            Console.Write("Please enter the customer's first name:");
            fname = Console.ReadLine();
            Console.Write("Please enter the customer's last name:");
            lname = Console.ReadLine();
            Console.Write("Please enter the customer's phone:");
            phone = Console.ReadLine();
            if (aCoord.addCustomer(fname, lname, phone))
            {
                Console.WriteLine("Customer successfully added..");
            }
            else
            {
                Console.WriteLine("Customer was not added..");
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void addFlight()
        {
            int flightNo, maxSeats;
            string origin, destination;

            Console.Clear();
            Console.WriteLine("-----------Add Flight----------");
            Console.Write("Please enter the flight number:");
            flightNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please the maximum number of seats:");
            maxSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the port of Origin:");
            origin = Console.ReadLine();
            Console.Write("Please enter the destination port:");
            destination = Console.ReadLine();
            if (aCoord.addFlight(flightNo, origin, destination, maxSeats))
            {
                Console.WriteLine("Flight successfully added..");
            }
            else
            {
                Console.WriteLine("Flight was not added..");
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void showMainMenu()
        {
            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.\nPlease select a choice from the menu below:\n");
            Console.WriteLine("1: Add Flight\n2: Add Customer\n3: View Flights\n4: View Customers");
            Console.WriteLine("5: Delete Customer\n6: Delete Flight\n7: Add Booking\n8: View Bookings");
            Console.WriteLine("9:Exit");
        }

        public static int getValidChoice()
        {
            int choice;
            showMainMenu();
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 9))
            {
                showMainMenu();
                Console.WriteLine("Please enter a valid choice:");
            }
            return choice;
        }

        public static void addBooking()
        {

            int cid, fid;

            Console.Clear();
            Console.WriteLine(aCoord.customerList());
            Console.Write("Customer ID: ");
            cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aCoord.flightList());
            Console.Write("Flight ID: ");
            fid = Convert.ToInt32(Console.ReadLine());
            
            if(aCoord.addBooking(fid, cid, DateTime.Now.ToString("yyyy-MM-dd")))
            {
                Console.WriteLine("Booking successfully added");
            }
            else
            {
                Console.WriteLine("Booking could not be successfully added");
            }
            
            Console.ReadKey();
        }

        public static void viewBookings()
        {
            Console.WriteLine(aCoord.bookingList());
            Console.ReadKey();
        }


        public static void runProgram()
        {
            int choice = getValidChoice();
            while (choice != 9)
            {
                if (choice == 1) { addFlight(); }
                if (choice == 2) { addCustomer(); }
                if (choice == 3) { viewFlights(); }
                if (choice == 4) { viewCustomers(); }
                if (choice == 5) { deleteCustomer(); }
                if (choice == 6) { deleteFlight(); }
                if (choice == 7) { addBooking(); }
                if (choice == 8) { viewBookings(); }
                choice = getValidChoice();
            }
        }

        static void Main(string[] args)
        {
            aCoord = new AirlineCoordinator(100, 2, 30);
            runProgram();
            Console.WriteLine("Thank you for using XYZ Airlines System. Press any key to exit.");
            Console.ReadKey();
        }
    }

}
