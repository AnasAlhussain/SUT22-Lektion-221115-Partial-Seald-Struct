using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
    partial class PartialCustomer
    {
        public void DispalyFullName()
        {
            Console.WriteLine("Full Name is : {0} {1}", _firstName, _lastNAme);
        }

    }
}
