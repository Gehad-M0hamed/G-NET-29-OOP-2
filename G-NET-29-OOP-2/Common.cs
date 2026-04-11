using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_2
{
    public class Common
    {
        public enum TicketType
        {
            Standard,
            VIP,
            IMAX
        }

        public struct SeatLocation
        {
            public char Row;
            public int Number;

            public SeatLocation(char row, int number)
            {
                Row = row;
                Number = number;
            }

            public override string ToString() => $"{Row}{Number}";
        }
    }

}
