using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignment
{
    internal class Bookstore
    {
        static void Main()
        {
            Hashtable books=new Hashtable();
            books.Add(2, "abc");
            books.Add(1, "xyz");
            books.Add(5, "lmn");
            foreach(var k in books.Keys)
            {
                Console.WriteLine("bookid={0} bookname={1}",k,books[k]);
            }
        }
    }
}
