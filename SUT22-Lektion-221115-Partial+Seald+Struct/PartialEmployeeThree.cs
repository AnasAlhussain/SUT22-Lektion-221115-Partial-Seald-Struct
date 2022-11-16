using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
    public partial class PartialEmployee
    {
        public void DispalyEmployeeData()
        {
            Console.WriteLine("Employee Details :");
            Console.WriteLine("First Name : {0}", _firstName);
            Console.WriteLine("Last Name : {0}", _lastName);
            Console.WriteLine("Salary : {0}", _salary);
        }
    }
}
