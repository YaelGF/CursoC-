using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
            Suma(1, 5);
            int m = Mul(4, 3);
            Console.WriteLine(m);
        }
        static void Show()
        {
            Console.WriteLine("Hola soy un texto que se imprime desde una funcion");
        }
        static void Suma(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
