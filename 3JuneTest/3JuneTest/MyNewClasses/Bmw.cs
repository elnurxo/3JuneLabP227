using System;
using System.Collections.Generic;
using System.Text;

namespace _3JuneTest.MyNewClasses
{
    class Bmw : ICar
    {
        public string Name { get; set; }
        public double CurrentFuel { get; set; }


        public void Drive(double fuel)
        {
            if (CurrentFuel-fuel>0)
            {
                CurrentFuel -= fuel;
                Console.WriteLine($"current fuel is {CurrentFuel}, {fuel} lt fuel is used!");
            }
            else
                Console.WriteLine("Fuel is low!");
           
        }

        public void Horn()
        {
            Console.WriteLine("Beep Beep");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} is a car.");
        }
    }
}
