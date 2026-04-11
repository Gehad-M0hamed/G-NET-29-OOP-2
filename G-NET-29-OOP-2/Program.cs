using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_29_OOP_2
{
    internal class Program
    {

        #region Q1:
        //a)
        //*Public Fields(Violation of Data Hiding):
        //Owner and Balance are public allows any external code to modify the account balance,without any validation.
        // * Lack of Validation:
        //    he Withdraw method subtracts an amount directly from the Balance without checking if the amount is positive or if the account has sufficient funds.
        //b)*Change access modifiers to private
        //    * Use get and set.
        //    * Add Validation Logic
        //    *Use Accessor Restrictions.
        //c)  *Exposing fields directly means  object loses control over its data, allowing external code to set invalid values that could break the application.
        //    *It makes future changes difficult
        //    * Security:It violates the principle of (Data Hiding).
        #endregion

        #region Q2:
        //Field:*Direct data storage
        //      * No validation
        //      * Breaks encapsulation
        //Property:
        //    *Controlled access
        //    *Can validate
        //    *Enforces encapsulation

        #endregion

        #region Q3:
        //a)Indexer,allow an instance of  class to be accessed using array.
        //- provides  clean and more intuitive way to manage internal collections or arrays.
        //b)IndexOutOfRangeException:names has  fixed size of 5( 0 to 4), index 10 is out of bounds.
        //*Make it safer :by adding Validation Logic inside the get and set.
        //*if statement to check if the index is within the valid range.
        //c)yes, through Overloading
        //* It  useful in  PhoneBook class where we want to find an item by an integer ID(int index) OR by  name/ISBN(string key)
        #endregion

        #region Q4:

        //a)TotalOrders belongs to the Order class.
        //*Item is a instance field, every new Order object has its own unique Item.
        //*TotalOrders is a static field,there is only one copy in memory that all objects share to get the global count.
        //b)No ,Static methods belong to the class the static method doesn't know "which" object's Item to access.

        #endregion

        #region Part 02:
        
        
            static void Main()
            {
                Cinema myCinema = new Cinema();

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Enter data for Ticket {i}:");
                    Console.Write("Movie Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                    Common.TicketType type = (Common.TicketType)int.Parse(Console.ReadLine());

                    Console.Write("Seat Row: ");
                    char row = char.Parse(Console.ReadLine().ToUpper());

                    Console.Write("Seat Number: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Ticket t = new Ticket(name, type, new Common.SeatLocation(row, num), price);
                    myCinema.AddTicket(t);
                }

                Console.WriteLine("\nAll Tickets:");
                for (int i = 0; i < 3; i++)
                {
                    if (myCinema[i] != null) myCinema[i].PrintTicket();
                }

                Console.Write("\nEnter movie name to search: ");
                string searchName = Console.ReadLine();
                Ticket found = myCinema[searchName];
                if (found != null) found.PrintTicket();
                else Console.WriteLine("Not found.");

                Console.WriteLine($"\nTotal Sold: {Ticket.GetTotalTicketsSold()}");
                Console.WriteLine($"Ref 1: {BookingHelper.GenerateBookingReference()}");
                Console.WriteLine($"Ref 2: {BookingHelper.GenerateBookingReference()}");
                Console.WriteLine($"Group Price: {BookingHelper.CalcGroupDiscount(5, 80)}");
            }
        

        #endregion














    }
}
