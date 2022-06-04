using System;
using System.Collections.Generic;
using System.Text;

namespace _3JuneTest.MyNewClasses
{
    interface ICar
    {
        string Name { get; set; }
        double CurrentFuel { get; set; }


        void ShowInfo();
        void Horn();
        void Drive(double fuel);
    }
}
