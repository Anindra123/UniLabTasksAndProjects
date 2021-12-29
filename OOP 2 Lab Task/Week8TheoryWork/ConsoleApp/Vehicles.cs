using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Vehicles : ITruck, ICar
    {
        void ITruck.Accelarate()
        {
            Console.WriteLine("Truck speed went from 10kmph to 50kmph");
        }
        //explicit interface
        void ICar.Accelarate()
        {
            Console.WriteLine("Car speed went from 20kmph to 50kmph");
        }



    }
}
