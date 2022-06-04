using System;
using System.Collections.Generic;
using System.Text;

namespace _3JuneTest.MyClasses
{
    internal abstract class Product
    {
        private string _name;
        public double Price;

        public string Name
        {
            get => _name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && Char.IsUpper(value[0]))
                {
                    _name = value;
                }
            }
        }

        public abstract void DetailProduct();

        public virtual void GeneralInfo()
        {
            Console.WriteLine($"{Name} is product");
        }
    }
}
