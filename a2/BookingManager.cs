using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2
{
    class BookingManager
    {
        private Booking[] bookings;
        private int bookingNum;


        public BookingManager(int max = 100)
        {
            bookingNum = 0;
            bookings = new Booking[max];
        }

        public void addBooking(Flight f, Customer c, string d)
        {
            bookings[bookingNum] = new Booking(f, c, d, bookingNum++);
        }

        public int getCount() { return bookingNum; }
        public string getInfo(int bn)
        {
            return bookings[bn].toString();
        }

        public string getBookingList()
        {
            string r = "";
            for (int i = 0; i < getCount(); i++)
            {
                r += getInfo(i);
            }
            return r;
        }
    }
}
