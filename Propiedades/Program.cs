using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(100,DateTime.Now);
            Console.WriteLine(sale.Date);
            Console.WriteLine(sale.Total);
            sale.Total = 291;
            Console.WriteLine(sale.Total);
                
        }

        class Sale
        {
            private int total;
            private DateTime date;

            public Sale(int total, DateTime date)
            {
                this.date = date;
                this.total = total;
            }

            public string Date
            {
                get
                {
                    return date.ToLongDateString();
                }
            }

            public int Total
            {
                get
                {
                    return total;
                }

                set
                {
                    if (value < 0)
                        value = 0;
                    total = value;
                }
            }

        }
    }
}
