using System;

namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(100, DateTime.Now);
            Console.WriteLine(sale.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Hi");
        } 
    }
}
