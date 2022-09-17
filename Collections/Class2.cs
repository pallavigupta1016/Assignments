using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsAssignment
{
    internal class Class2
    {
        static void Main()
        {
            ArrayList names = new ArrayList() { "Zayn", "Hilda", "Mannat" };
            names.Add("Pallavi");
            names.Sort();
            names.Reverse();
            foreach(var name in names)
            {
                Console.WriteLine(name as string);
            }
        }
    }
}
