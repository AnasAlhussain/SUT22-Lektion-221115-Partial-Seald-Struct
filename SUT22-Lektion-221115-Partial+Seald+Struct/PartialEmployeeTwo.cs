using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
   public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is : {0} {1}", _firstName, _lastName);
        }


       
    }
}
