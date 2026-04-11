using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_2
{
    public class Ticket
    {
        private string _movieName;
        private double _price;
        private static int ticketCounter = 0;

        public int TicketId { get; private set; }

        public string MovieName
        {
            get { return _movieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _movieName = value;
            }
        }

        public Common.TicketType Type { get; set; }
        public Common.SeatLocation Seat { get; set; }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }

        public double PriceAfterTax
        {
            get { return Price * 1.14; }
        }

        public Ticket(string movieName, Common.TicketType type, Common.SeatLocation seat, double price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | Movie: {MovieName} | Type: {Type} | Seat: {Seat} | Price: {Price:F2} | After Tax: {PriceAfterTax:F2}");
        }
    }
}
