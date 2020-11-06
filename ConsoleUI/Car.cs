using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public string CarType { get; set; } = "Car";
        public bool HasTrunk { get; set; } = true;
        public int NumOfSpareTires { get; set; } = 1;
        public override void DriveAbstract()
        {

            Console.WriteLine($"This car can be driven");
            //throw new NotImplementedException();
        }
    }
}
