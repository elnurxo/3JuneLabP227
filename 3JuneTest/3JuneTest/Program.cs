using _3JuneTest.MyClasses;
using _3JuneTest.MyNewClasses;
using System;

namespace _3JuneTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink()
            {
                Name = "Coca cola",
                Price = 2.5,
                IsAlchohol = false,
                Volume = 1.5
            };
            drink1.DetailProduct();
            drink1.GeneralInfo();

            Candy candy1 = new Candy()
            {
                Name = "Kit kat",
                Price = 1.2,
                SugarPercentage = 32.2,
            };
            candy1.DetailProduct();
            candy1.GeneralInfo();



            //INTERFACE
            #region interface
            Bmw bmw = new Bmw()
            {
                Name = "X6",
                CurrentFuel = 6
            };
            bmw.Horn();
            bmw.ShowInfo();
            bmw.Drive(7);
            #endregion

        }
    }
}
