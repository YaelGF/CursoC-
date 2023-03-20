using System;
using System.Text.Json;

namespace json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Corona",
                Brand = "Modelo"
            };

            string json = JsonSerializer.Serialize(myBeer);
            Console.WriteLine(json);
            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Dos X",
                    Brand = "Heiniken"
                },
                new Beer()
                {
                    Name = "Tecate",
                    Brand = "Modelo"
                }
            };

            string json2 = JsonSerializer.Serialize(beers);
            Console.WriteLine(json2);
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);
        }
    }
    public class Beer
    {
        public string Name { get; set; }

        public string Brand { get; set; }
    }
}
