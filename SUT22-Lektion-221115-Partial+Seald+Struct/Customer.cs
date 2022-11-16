using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{
   public class Customer
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



        public void DispalyFullName()
        {
            Console.WriteLine("Full Name is : {0} {1}", _firstName, _lastNAme);
        }

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
