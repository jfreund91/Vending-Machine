using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone.Classes
{
    /// <summary>
    /// Represents a Candy vending machine item.
    /// </summary>
    public class CandyType : VendingMachineItem
    {
        /// <summary>
        /// Returns the sound made when Candy is consumed.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedSound()
        {
           return "Munch Munch, Yum!"; 
        }

        public CandyType(string location, string productName, decimal price)
            : base(location, productName, price)
        {

        }
    }
}
