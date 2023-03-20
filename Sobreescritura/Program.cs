using System;

namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());


            Sale sale = new Sale(10);
            sale.Add(5);
            sale.Add(10);

            Console.WriteLine(sale.GetTotal());

            SaleWithTax saleWithTax = new SaleWithTax(10,1.16m);

            saleWithTax.Add(5);
            saleWithTax.Add(10);

            Console.WriteLine(saleWithTax.GetTotal());

        }
    }

    public class A
    {
        public virtual string Hi()
        {
            return "Hola soy A";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return "Hola soy b, pero tambien " + base.Hi();
        }
    }

    public class Sale
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;


        public Sale(int n)
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0;
        }

        public void Add(decimal amount)
        {
            if(_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;
            for(int i = 0; i<_amounts.Length; i++)
            {
                result += _amounts[i];
            }
            return result;
        }
    }
    public class SaleWithTax : Sale
    {
        private decimal _tax;
        public SaleWithTax(int n, decimal tax): base(n)
        {
            _tax = tax;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _tax;
        }
    }
}

