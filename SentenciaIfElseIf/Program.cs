using System;

namespace SentenciaIfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = false;

            if (areYouHungry && youHaveMoney && isOpenRestaurant("Lonches pepe",7))
            {
                Console.WriteLine("Come");
            }
            else
            {
                Console.WriteLine("Ponte a jalar");
            }
            if (areYouHungry || youHaveMoney)
            {
                Console.WriteLine("Come");
            }
        }

        static bool isOpenRestaurant(string name, int hour = 0)
        {
            if(name == "Lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }else if(name == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
