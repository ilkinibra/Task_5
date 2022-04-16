using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5.Models
{
    class Bus:Vehicle
    {
        private int _passengerCount;
        public int PassengerCount
        {
            get { return _passengerCount; }
            set
            {
                if (value > 0 && value<40)
                {
                    _passengerCount = value;
                }
            }
        }

        public Bus(int passengercount,int year):base(year)
        {
            PassengerCount = passengercount;
            Year = year;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PassengerCount:{PassengerCount}\nYear:{Year}");
        }
    }
}
