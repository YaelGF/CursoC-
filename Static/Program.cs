using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People yael = new People()
            {
                Name = "Yael",
                Age = 21
            };

            People juan = new People()
            {
                Name = "Juan",
                Age = 36
            };

            Console.WriteLine(People.Count);

            Console.WriteLine(People.GetCount());

            A.Some();
        }

        public static  class A
        {
            public static void Some()
            {
                Console.WriteLine("Algo");
            }
        }

        public class People
        {

            public static int Count = 0;

            public string Name { get; set; }

            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }
        }
    }
}
