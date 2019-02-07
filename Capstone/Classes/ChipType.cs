using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    class ChipType:VendingMachineItem
    {
         
        public override string ConsumedSound()
        {
            return "Crunch,Crunch, Yum!";
        }

        public ChipType(string location, string productName, decimal price)
            : base(location, productName, price)
        {

        }
    }
}

