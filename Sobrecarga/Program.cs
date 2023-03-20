using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine(math.Sum(1,2));

            Console.WriteLine(math.Sum("1", "2"));

            int[] numeros = new int[] { 1, 2, 3 };

            Console.WriteLine(math.Sum(numeros));
        }
    }

    public class Math
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Sum(string n1, string n2)
        {
            return int.Parse(n1) + int.Parse(n2);
        }

        public int Sum(int[] numeros )
        {
            int result = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                result += numeros[i];
            }

            return result;
        }
    }
}
