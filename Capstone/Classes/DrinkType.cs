using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// <summary>
    /// Represents a drink vending machine item.
    /// </summary>
    class DrinkType : VendingMachineItem
    {
        /// <summary>
        /// Returns the sound a drink makes when consumed.
        /// </summary>
        /// <returns></returns>
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
