using System;
using System.Data.SqlClient;

namespace SUT22_Lektion_221115_Partial_Seald_Struct
{

    //Struct

    struct Book
    {
        public int Id;
        public string title;
        public string author;
        public string subject;



        //public void getValues(string t,)
        //{

        //}
        public void dispalyData()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
        }
    }







    interface IStudent
    {

    }
    struct Student1 : IStudent
    {
        private int _id;
        private string name;


        public int ID { get => _id; set => _id = value; }
        public string Name { get => name; set => name = value; }

        public Student1(int i , string n)

        {
            _id = i;
            name = n;
        }
        public void PrintDetails()
        {
            Console.WriteLine("ID = {0} \n Name = {1}", _id, name);
        }

       
    }






    //SealdClass
      class User 
    {
        public string name = "Tobias Qlok";
        public string location = "Stockholm";

        public User()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Location : {0}", location);
        }

        ~User()
        {

        }
        
    }



    public class Details 
    {
        public int age = 38;

        public void GetAge()
        {
            Console.WriteLine("Age : {0}", age);
        }
    }


    //Seald Method

    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base class A Test Method");
        }
    }

    public class B : A
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived class B Method");
        }

        public override void Test()
        {
            Console.WriteLine("Derived class B Test Method");
        }
    }

    public class C : B
    {
        //public override void GetInfo()
        //{
        //    Console.WriteLine("Derived class C Method");
        //}

        public override void Test()
        {
            Console.WriteLine("Derived class C Test Method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Book book1;
            Book book2;
            Book book3;





            //book 1 
            book1.title = "C# progrmming";
            book1.author = "Tobias";
            book1.subject = "C# progrmming tutorial";
            book1.Id = 101;
            book1.dispalyData();


            Console.WriteLine("------------------");
            //book2 
            book2.title = "Python";
            book2.author = "Raidar";
            book2.subject = "Python tutorial";
            book2.Id = 102;
            book2.dispalyData();


            //Student1 SS1;
            //SS1.ID = 101;




            //Seald class
            //Details d = new Details();
            //d.GetAge();

            //User u = new User();
            //u.GetInfo();

            //C c = new C();

            //c.GetInfo();

            //Employee E1 = new Employee();

            //E1.FirstName = "Tobias";
            //E1.LastName = "Qlok";
            //E1.Salary = 1258.5;
            //E1.DisplayFullName();




            //PartialEmployee PEO = new PartialEmployee();
            //PEO.FirstName = "Anas";
            //PEO.LastName = "Qlok";
            //PEO.Salary = 20252.6;
            //PEO.DisplayFullName();
            //Console.WriteLine("--------------------------");
            //PEO.DispalyEmployeeData();




            //Student S1 = new Student();
            //S1.FirstNAme = "Alvin";
            //S1.LastNAme = "Alvin";

            //string FullName =  S1.GetFullName();
            //Console.WriteLine(FullName);



            //PartialStudent PStudent = new PartialStudent();
            //PStudent.FirstNAme = " Anas";
            //PStudent.LastNAme = "Qlok";
            //PStudent.Email = "an@an.com";
            //string FN =  PStudent.GetFullName();
            //Console.WriteLine("HEllo from Partial Class , Full Name : {0} and Email :{1}",
            //    FN,PStudent.Email);



            //User U = new User();
            //U.FirstName = "Tobias";

            //SqlConnection sqlConnection = new SqlConnection();

            //PartialCustomer PC = new PartialCustomer();
            //PC.ID = 101;
            //PC.FirstName = "Reidar";
            //PC.LastName = "Qlok";
            //PC.Email = "4reidar@qlok.com";
            //PC.DispalyFullName();
            //PC.DisplayInfo();

            Console.ReadKey();
        }
    }
}
