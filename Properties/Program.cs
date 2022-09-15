namespace PropertiesAssignment
{
    class Bookstore
    {
        
        public int isbn{ get { return isbn; }set { isbn = value; } }
        public string bookname { get { return bookname; } set { bookname = value; } }
        public string bookauthor { get { return bookauthor; } set { bookauthor = value; } }
        public string booktitle { get { return booktitle; } set { booktitle = value; } }
        public int bookprice { get { return bookprice; } set { bookprice = value; } }

        static void Main(string[] args)
        {
            Bookstore[] b = new Bookstore[10];
            Console.WriteLine("Enter no of books");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                b[i]= new Bookstore();
                Console.WriteLine("Enter isbn");
                b[i].isbn = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book name");
                b[i].bookname = Console.ReadLine();
                Console.WriteLine("Enter Book Title");
                b[i].booktitle = Console.ReadLine();
                Console.WriteLine("Enter Book author");
                b[i].bookauthor = Console.ReadLine();
                Console.WriteLine("Enter Book price");
                b[i].bookprice = int.Parse(Console.ReadLine());
                sum += b[i].bookprice;
            }
            Console.WriteLine(sum);
        }
    }
}