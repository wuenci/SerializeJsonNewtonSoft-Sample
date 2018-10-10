using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeJsonNewtonSoftDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee = new Coffee
            {
                Brand = "Nescafe",
                Beans = { "Arabica", "Columbia" }
            };


            var coffeeJson = Newtonsoft.Json.JsonConvert.SerializeObject(coffee);
            Console.WriteLine(coffeeJson);

            Console.ReadKey();
        }
    }
}
