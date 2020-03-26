using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2
{
    class Booking
    {
        private Flight f;
        private Customer c;
        private string date;
        private int bookingNum;

        public Booking(Flight fi, Customer ci, string datei, int bNum)
        {
            f = fi;
            c = ci;
            date = datei;
            bookingNum = bNum;
        }

        public string getDate() { return date; }
        public int getBookingNum() { return bookingNum; }
        public string getCustomerName() { return c.getFirstName() + " " + c.getLastName(); }
        public int getFlightNum() { return f.getFlightNumber(); }

        public string toString()
        {
            return "DATE: " + getDate() + " Booking #: " + getBookingNum() + " Customer: " + getCustomerName() + " Flight #: " + getFlightNum();
        }

    }
}
