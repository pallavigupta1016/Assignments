using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAssignment
{
    class building
    {
        string type;
        string capacity;
        string dimension="0";
        int floor=0;
        string dateofcompletion;

        public building(string type, string capacity, string dateofcompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dateofcompletion = dateofcompletion;
        }

        public void Type(string type)
        {
            if (type == "flat")
            {
                Console.WriteLine("Enter floor number");
                floor = int.Parse(Console.ReadLine());
            }
            else if (type == "villa")
            {
                Console.WriteLine("Enter dimensions");
                dimension = Console.ReadLine();
            }
        }

        public void showdata()
        {
            Console.WriteLine(type + '\n' + capacity + '\n' + dateofcompletion + '\n' + dimension + '\n' + floor);
        }

        static void Main()
        {
            building b = new building("flat", "4BHK", "2010");
            b.Type("flat");
            b.showdata();
        }
    }
}
