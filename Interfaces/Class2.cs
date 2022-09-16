using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAssinment
{
    interface sales
    {
        public void yearSales();
    }
    abstract class A
    {
        int dailySale;
        public void dailySales(int dailySale)
        {
            Console.WriteLine("Daily Sales = " + dailySale);
        }
        public abstract void monthlySales(int dailySale) ;
    }
    class B : A, sales
    {
        int dailySale;

        public B(int dailySale)
        {
            this.dailySale = dailySale;
        }

        public override void monthlySales(int dailySales)
        {
            Console.WriteLine("Monthly Sales = " + 30 * dailySale);
        }
        public void yearSales()
        {
            Console.WriteLine("Annual Sales = " + 12 * 30 * dailySale);
        }
    }
    class Class2
    {
        static void Main()
        {
            B s = new B(400);
            s.dailySales(400);
            s.monthlySales(400);
            sales s1 = new B(400);
            s1.yearSales();
        }
    }
}
