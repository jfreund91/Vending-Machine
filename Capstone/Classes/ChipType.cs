using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a Chip vending machine item.
    /// </summary>
    class ChipType :VendingMachineItem
    {
         /// <summary>
         /// Returns the sound chips make when they are consumed.
         /// </summary>
         /// <returns></returns>
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

