using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                23,3,6,5,10,33,12
            };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            string i = "Hola";

            foreach(var j in i)
            {
                Console.WriteLine(j);
            }

            var students = new List<People>()
            {
                new People(){Name = "Yael", Country = "México"},
                new People(){Name = "Monica", Country = "Argentina"},
                new People(){Name = "Jesarim", Country = "Francia"}
            };

            Show(students);

            students.RemoveAt(0);
            Show(students);
        }
        static void Show(List<People> students)
        {
            Console.WriteLine("-----------------------");
            foreach (var stundent in students)
            {
                Console.WriteLine($"Nombre: {stundent.Name}, País: {stundent.Country}");
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }


    }
}
