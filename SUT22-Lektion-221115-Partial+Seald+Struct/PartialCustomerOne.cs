using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
    partial class PartialCustomer
    {
        private int _id;
        private string _firstName;
        private string _lastNAme;
        private string _email;




        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastNAme; }
            set { _lastNAme = value; }
        }


        public int ID { get => _id; set => _id = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
