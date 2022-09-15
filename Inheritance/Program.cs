using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class furniture
    {
        public int orderId, amount, qty;
        public string date, ftype, pmode;

        public furniture(int orderId, int amount, int qty, string date, string ftype, string pmode)
        {
            this.orderId = orderId;
            this.amount = amount;
            this.qty = qty;
            this.date = date;
            this.ftype = ftype;
            this.pmode = pmode;
        }

        public void display()
        {
            Console.WriteLine($"orderId={orderId} Amount={amount} Quantity={qty} date={date} payment={pmode} furniture type={ftype}");
        }
    }
    class chair : furniture
    {
        public int rate;
        string chairType, purpose;

        public chair(int orderId, int amount, int qty, string date, string ftype, string pmode,string chairType,string purpose,int rate):base( orderId,  amount,  qty,  date,  ftype, pmode)
        {
            this.chairType = chairType;
            this.purpose = purpose;
            this.rate = rate;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"ChairType={chairType} Purpose={purpose} rate={rate}");
        }
    }
    class woodChair : chair
    {
        public string woodType;

        public woodChair(int orderId, int amount, int qty, string date, string ftype, string pmode, string chairType, string purpose, int rate,string woodType) :base( orderId,  amount,  qty,  date,  ftype,  pmode,  chairType,  purpose,  rate)
        {
            this.woodType = woodType;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"WoodType={woodType}");
        }
    }
    class steelChair : chair
    {
        public string steelType;

        public steelChair(int orderId, int amount, int qty, string date, string ftype, string pmode, string chairType, string purpose, int rate, string steelType) : base(orderId, amount, qty, date, ftype, pmode, chairType, purpose, rate)
        {
            this.steelType = steelType;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"steelType={steelType}");
        }
    }
    class plasticChair : chair
    {
        public string plasticType;

        public plasticChair(int orderId, int amount, int qty, string date, string ftype, string pmode, string chairType, string purpose, int rate, string plasticType) : base(orderId, amount, qty, date, ftype, pmode, chairType, purpose, rate)
        {
            this.plasticType = plasticType;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"plasticType={plasticType}");
        }
    }
    class cot : furniture
    {
        public int rate;
        string cotType, capacity;

        public cot(int orderId, int amount, int qty, string date, string ftype, string pmode,string cotType,string capacity, int rate) : base(orderId, amount, qty, date, ftype, pmode)
        {
            this.cotType = cotType;
            this.capacity = capacity;
            this.rate = rate;
        }

        public void display()
        {
            base.display();
            Console.WriteLine($"cotType={cotType} capacity={capacity} rate={rate}");
        }
    }

    class furnitureExecution
    {
        static void Main()
        {
            woodChair w = new woodChair(1, 1000, 3, "15sep", "wood", "debitcard","chair","office",300,"RoseWood");
            w.display();
            cot c = new cot(1,2000,2,"15sep","cot","creditcard","steel","double",200);
            c.display();
        }
    }
}
