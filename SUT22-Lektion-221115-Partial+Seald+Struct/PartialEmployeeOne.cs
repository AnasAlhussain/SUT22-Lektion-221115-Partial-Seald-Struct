using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
    public partial class PartialEmployee
    {
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _gender;



        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
