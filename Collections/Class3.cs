using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Class3
    {
        static void Main()
        {
            SortedList e = new SortedList();
            e.Add(3, "Tanvi");
            e.Add(2, "Manav");
            e.Add(5, "Priya");
            e.Add(1, "Sonal");
            foreach(var k in e.Keys)
            {
                Console.WriteLine("emp code={0} emp name={1}", k, e[k]);
            }
        }
    }
}
