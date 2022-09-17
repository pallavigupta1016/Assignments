using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CollectionsAssignment;

namespace HandsOnNonGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    interface IStudentRepositroy
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        ArrayList GetStudents();
        void DeleteStudent(int id);
        void UpdateStudent(int id, int age);
    }
    class StudentRepository : IStudentRepositroy
    {
        ArrayList list = new ArrayList();
        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public void DeleteStudent(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (((Student)list[i]).Sid == id)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        public Student GetStudent(int id)
        {
            foreach (Student s in list)
            {
                if (s.Sid.Equals(id))
                {
                    return s;
                }
            }
            return null;
        }

        public ArrayList GetStudents()
        {
            return list;
        }

        public void UpdateStudent(int id, int age)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (((Student)list[i]).Sid == id)
                {
                    ((Student)list[i]).Age = age;
                }
            }
        }
    }

    class Demo2
    {
        static void Main()
        {
            //write menu driven code to test all the student repository functions.
            StudentRepository s = new StudentRepository();
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("Enter option no:\n" +
                "1.AddStudent\n" +
                "2.Get student\n" +
                "3.Get students\n" +
                "4.Update student\n" +
                "5.Remove student\n" +
                "6.Exit");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Student s1=new Student();
                            Console.WriteLine("Enter student id");
                            s1.Sid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter student name");
                            s1.Sname = Console.ReadLine();
                            Console.WriteLine("Enter student age");
                            s1.Age = int.Parse(Console.ReadLine());
                            s.AddStudent(s1);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter student id:");
                            int id=int.Parse(Console.ReadLine());
                            Student s1= s.GetStudent(id);
                            Console.WriteLine($"Student name={s1.Sname} age={s1.Age}");

                        }
                        break;
                    case 3:
                        {
                            ArrayList arr= s.GetStudents();
                            foreach(Student item in arr)
                            {
                                Console.WriteLine($"Student id={item.Sid} name={item.Sname} age={item.Age}");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter student id");
                            int Sid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter student age");
                            int Age = int.Parse(Console.ReadLine());
                            s.UpdateStudent(Sid, Age);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter student id");
                            int Sid = int.Parse(Console.ReadLine());
                            s.DeleteStudent(Sid);
                        }
                        break;
                    case 6:
                        {
                            flag = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Enter correct option number");
                        }
                        break;
                }
            }
            
        }
    }
}
