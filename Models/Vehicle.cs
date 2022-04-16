using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5.Models
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public  int Year { get; set; }
        public abstract void ShowInfo();

        public Vehicle(int year)
        {
            Year = year;
        }
    }
}
