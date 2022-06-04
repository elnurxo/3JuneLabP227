using System;
using System.Collections.Generic;
using System.Text;

namespace _3JuneTest.MyClasses
{
    class Candy:Product
    {
        public double SugarPercentage;

        public override void DetailProduct()
        {

            Console.WriteLine($"{Name} is candy. {SugarPercentage}% sugar");
        }
    }
}
