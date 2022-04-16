using System;
using Task_5.Models;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Hyundai", "Grandeur", 2007,280);
            Bus bus = new Bus(30, 2002);
            Vehicle[] vehicle = {car,bus};
            foreach (Vehicle item in vehicle)
            {
                item.ShowInfo();   
            }
        }
    }
}
        