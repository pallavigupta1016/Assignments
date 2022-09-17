using System.Collections;
namespace CollectionsAssignment
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            Console.WriteLine("Enter 10 numbers");
            for(int i = 0; i < 10; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }
            arr.Sort();
            foreach(var k in arr)
            {
                Console.WriteLine(Convert.ToInt32(k));
            }
        }
    }
}