using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAssignment
{
    class shapes
    {
        int a;
        public int area(int l,int b)
        {
            return l * b;
        }
        public double area(double b, double h)
        {
            return 0.5 * b * h;
        }
        public int area(int a)
        {
            return a * a;
        }
        public double area(double r)
        {
            return 3.14 * r * r;
        }
        static void Main()
        {
            shapes s = new shapes();
            Console.WriteLine(s.area(2, 4));
            Console.WriteLine(s.area(2.0, 4.0));
            Console.WriteLine(s.area(2));
            Console.WriteLine(s.area(2.0));
        }
    }
}
