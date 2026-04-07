using System.IO;
using System.Runtime.Intrinsics.X86;
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












        static void Main(string[] args)
        {
            
        }
    }
}
