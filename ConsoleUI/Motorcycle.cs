using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {

        public int GasMileage { get; set; }
        public int NumOfWheels { get; set; }

        public override void DriveAbstract()
        {
           // throw new NotImplementedException();
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
