using System;
using System.Collections.Generic;
using System.Text;


namespace Capstone.Classes
{
    public class CandyType : VendingMachineItem
    {
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
