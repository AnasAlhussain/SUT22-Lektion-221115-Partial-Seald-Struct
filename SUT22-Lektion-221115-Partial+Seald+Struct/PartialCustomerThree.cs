using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
   public partial class PartialCustomer
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Customer Details :");
            Console.WriteLine("ID = {0}", _id);
            Console.WriteLine("First Name = {0}", _firstName);
            Console.WriteLine("Last Name = {0}", _lastNAme);
            Console.WriteLine("E-Mail = {0}", _email);
        }
    }
}
