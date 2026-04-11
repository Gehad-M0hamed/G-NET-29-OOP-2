using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_2
{
    public static class BookingHelper
    {
        private static int referenceCounter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;
            return (numberOfTickets >= 5) ? total * 0.9 : total;
        }

        public static string GenerateBookingReference()
        {
            referenceCounter++;
            return $"BK-{referenceCounter}";
        }
    }
}
