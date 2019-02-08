using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a Gum vending machine item.
    /// </summary>
    public class GumType :VendingMachineItem
    {
        /// <summary>
        /// Returns the sound a gum item makes when consumed.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedSound()
        {
            return "Chew,Chew, Yum!";
        }

        public GumType(string location, string productName, decimal price)
            : base(location, productName, price)
        {

        }
    }
}

