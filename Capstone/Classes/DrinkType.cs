using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    class DrinkType : VendingMachineItem
    {
        public override string ConsumedSound()
        {
            return "Glug, Glug, Yum!";
        }
        public DrinkType(string location, string productName, decimal price) 
            : base(location, productName, price)
        {
        }
    }
}
