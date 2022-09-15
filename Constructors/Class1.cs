using System.Collections.Generic;

namespace ConstructorsAssignment
{
    class Person
    {
        string fname;
        string lname;
        string email;
        DateTime DOB;

        public Person()
        {
            fname = "Pallavi";
            lname = "Gupta";
            email = "abc@abc";
            DOB = DateTime.Now;
        }
        public Person(string fname, string lname, string email, DateTime DOB)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.DOB = DOB;
        }
        public Person(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }
        public Person(string fname, string lname,DateTime DOB)
        {
            this.fname = fname;
            this.lname = lname;
            this.DOB = DOB;
        }
        
        public void display()
        {
            Console.WriteLine("First name:{0} Last name:{1} Email:{2} DOB:{3}",fname,lname,email,DOB);
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter first name");
            p.fname=Console.ReadLine();
            Console.WriteLine("Enter last name");
            p.lname = Console.ReadLine();
            Console.WriteLine("Enter email");
            p.email = Console.ReadLine();
            Console.WriteLine("Enter dob");
            p.DOB = DateTime.Parse(Console.ReadLine());

            p.display();
        }
    }
}