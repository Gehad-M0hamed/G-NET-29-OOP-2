using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_2
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get => (index >= 0 && index < tickets.Length) ? tickets[index] : null;
            set { if (index >= 0 && index < tickets.Length) tickets[index] = value; }
        }

        public Ticket this[string movieName]
        {
            get
            {
                foreach (var t in tickets)
                {
                    if (t != null && t.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                        return t;
                }
                return null;
            }
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
    }
}
