using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Make { get; set; } = "Unknown";
        public string Model { get; set; } = "Type";
        public int Year { get; set; } = 1900;

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is my Motorcycle!");
        }
    }
}
