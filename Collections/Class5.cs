using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsAssignment
{
    class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public string std { get; set; }

        
    }
    internal class Class5
    {
        static void Main()
        {
            ArrayList students = new ArrayList();
            Student s1 = new Student() { rollno = 12, name = "Sia", std = "8th" };
            Student s2 = new Student(){ rollno = 1, name = "pria", std = "7th" };
            students.Add(s1);
            students.Add(s2);
            students.Add(new Student() { rollno = 5, name = "Pallavi", std = "11th" });
            foreach(Student s in students)
            {
                Console.WriteLine($"{s.rollno} {s.name} {s.std}");
            }
        }
    }
}
