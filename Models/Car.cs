using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5.Models
{
    class Car : Vehicle
    {
        private int _maxSpeed;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed 
        { 
            get {return _maxSpeed; }
            set
            {
                if (value>0)
                {
                    _maxSpeed = value;
                }
            } 
        }

        
        public Car(string brand,string model,int year,int maxspeed):base(year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            MaxSpeed = maxspeed;
        }
       

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}\nModel:{Model}\nYear:{Year}\nMaxSpeed:{MaxSpeed}");
        }
    }
}
