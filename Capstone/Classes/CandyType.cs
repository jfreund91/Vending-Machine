using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class CandyType : VendingMachineItems
    {
        public override string ConsumedSound()
        {
           return "Munch Munch, Yum!"; 
        }

        public CandyType(string location, string productName, decimal price, string productType)
            : base(location, productName, price, productType)
        {

        }
    }
}
