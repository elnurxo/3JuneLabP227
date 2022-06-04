using System;
using System.Collections.Generic;
using System.Text;

namespace _3JuneTest.MyClasses
{
    class Drink:Product
    {
        public double Volume;
        public bool IsAlchohol;
        public override void DetailProduct()
        {
            string str;
            if (IsAlchohol)
                str = $"{Name} is alcohol";
            else
                str = $"{Name} is not alcohol";

            Console.WriteLine($"{Name} is drink. {Volume} ml, {str}");
        }

        public override void GeneralInfo()
        {
            Console.WriteLine($"{Name} is drink.");
        }
    }
}
