using System;
using System.Drawing;
using System.IO;
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













        static void Main(string[] args)
        {
            
        }
    }
}
