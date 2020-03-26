using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bManager;


        public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(custIdSeed, maxCust);
            bManager = new BookingManager();
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }

        public string flightList()
        {
            return flManager.getFlightList();
        }

        public string customerList()
        {
            return custManager.getCustomerList();
        }

        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public bool addBooking(int fid, int cid, string date)
        {
            Flight f = flManager.getFlight(fid);
            Customer c = custManager.getCustomer(cid);

            try
            {
                if (cid == c.getId())
                {
                    if (f.getMaxSeats() > f.getNumPassengers())
                    {
                        bManager.addBooking(f, c, date);
                        return true;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }

            return false;
        }

        public string bookingList()
        {
            return bManager.getBookingList();
        }

    }

}
