using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssinment
{
    interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    class tcs : GovtRules
    {
        public int empid;
        public string name, dept, desg;
        public double basicSalary;

        public tcs(int empid,string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary=basicSalary;
        }
        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month\r\n12 days of Sick Leave per year\r\n10 days of Previlage Leave per year\r\n";
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.2033*basicSalary;
            Console.WriteLine("{0} is pension fund", 0.0367 * basicSalary);
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted < 5)
                return 0.0;
            else if (serviceCompleted > 5 && serviceCompleted < 10)
                return basicSalary;
            else if (serviceCompleted > 10 && serviceCompleted < 20)
                return 2.0 * basicSalary;
            else
                return 3.0 * basicSalary;
        }
        public void display()
        {
            Console.WriteLine($"empid={empid}, name={name}, dept={dept}, desg={desg}, basicSalary={basicSalary}");
        }
    }
    class accenture : GovtRules
    {
        public int empid;
        public string name, dept, desg;
        public double basicSalary;

        public accenture(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }
        public string LeaveDetails()
        {
            return "2 day of Casual Leave per month\r\n5 days of Sick Leave per year\r\n5 days of Previlage Leave per year\r\n";
        }
        public double EmployeePF(double basicSalary)
        {
            return 0.24 * basicSalary;
        }
        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0.0;
            Console.WriteLine("Not Applicable");
        }
        public void display()
        {
            Console.WriteLine($"empid={empid}, name={name}, dept={dept}, desg={desg}, basicSalary={basicSalary}");
        }
    }
    class Class1
    {
        static void Main()
        {
            tcs e1 = new tcs(1, "Ankit", "xyz", "Analyst", 24567);
            Console.WriteLine("TCS");
            e1.display();
            Console.WriteLine("Employee PF: "+e1.EmployeePF(24567));
            e1.LeaveDetails();
            Console.WriteLine("Gratuity amount is " + e1.gratuityAmount(7, 24567));
            Console.WriteLine("Accenture");
            accenture e2 = new accenture(2, "Isha", "abc", "Sr Analyst", 34567);
            e2.display();
            Console.WriteLine("Employee PF: " + e2.EmployeePF(34567));
            e2.LeaveDetails();
            Console.WriteLine("Gratuity amount is " + e2.gratuityAmount(12, 34567));
        }
    }
}
