using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7] {
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis",
                null
            };

            bool run = true;

            for(int i = 0; i < friends.Length && run; i++)
            {
                Console.WriteLine(friends[i]);
            }


        }
    }
}
