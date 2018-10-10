using System;
using System.Collections.Generic;

namespace SerializeJsonNewtonSoftDemo
{
    public class Coffee
    {
        public string Brand { get; set; }
        public List<string> Beans { get; set; } = new List<string>();

        
        //public Coffee()
        //{
        //    //this.Beans = new List<string>();
        //}

        public void Drink()
        {
            Console.WriteLine("Drink coffee");
        }
    }
}
