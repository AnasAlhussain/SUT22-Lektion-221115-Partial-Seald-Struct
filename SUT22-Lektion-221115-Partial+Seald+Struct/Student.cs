using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
    public class Student
    {
        private string _firsName;
        private string _lastName;


        public string FirstNAme { get => _firsName; set => _firsName = value; }
        public string LastNAme { get => _lastName; set => _lastName = value; }



        public  string GetFullName()
        {
            return _firsName + " " + _lastName;
        }
    }
}
