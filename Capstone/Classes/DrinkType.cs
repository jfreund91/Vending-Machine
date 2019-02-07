using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    class DrinkType : VendingMachineItems
    {
        public override string ConsumedSound()
        {
            return "Glug, Glug, Yum!";
        }
        public DrinkType(string location, string productName, decimal price, string productType) 
            : base(location, productName, price, productType)
        {
        }
    }
}
