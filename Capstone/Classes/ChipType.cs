using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    class ChipsType:VendingMachineItems
    {
         
        public override string ConsumedSound()
        {
            return "Crunch,Crunch, Yum!";
        }

        public ChipsType(string location, string productName, decimal price, string productType)
            : base(location, productName, price, productType)
        {

        }
    }
}

