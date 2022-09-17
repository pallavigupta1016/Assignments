using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Class6
    {
        static void Main()
        {
            ArrayList ProgramManagers=new ArrayList();
            ArrayList projectManager = new ArrayList();
            ArrayList TeamLead = new ArrayList();
            ArrayList srProgrammer = new ArrayList();
            ArrayList jrProgrammer = new ArrayList();

            Console.WriteLine("Enter no of emplopees");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter designation");
                string desg = Console.ReadLine();
                desg = desg.ToLower();
                switch (desg)
                {
                    case "program manager":
                        {
                            Console.WriteLine("Enter name");
                            ProgramManagers.Add(Console.ReadLine());
                        }
                        break;
                    case "project manager":
                        {
                            Console.WriteLine("Enter name");
                            projectManager.Add(Console.ReadLine());
                        }
                        break;
                    case "team lead":
                        {
                            Console.WriteLine("Enter name");
                            TeamLead.Add(Console.ReadLine());
                        }
                        break;
                    case "senior programmer":
                        {
                            Console.WriteLine("Enter name");
                            srProgrammer.Add(Console.ReadLine());
                        }
                        break;
                    case "junior programmer":
                        {
                            Console.WriteLine("Enter name");
                            jrProgrammer.Add(Console.ReadLine());
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("enter proper designation");
                            i -= 1;
                        }
                        break;

                }
            }
            foreach (var name in ProgramManagers)
                Console.WriteLine($"Designation=Program Manager Name={name}");
            foreach (var name in projectManager)
                Console.WriteLine($"Designation=Project Manager Name={name}");
            foreach (var name in TeamLead)
                Console.WriteLine($"Designation=Team Lead Name={name}");
            foreach (var name in srProgrammer)
                Console.WriteLine($"Designation=Senior Programmer Name={name}");
            foreach (var name in jrProgrammer)
                Console.WriteLine($"Designation=Junior Programmer Name={name}");
        }
    }
}
