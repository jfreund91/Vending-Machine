using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class GumType :VendingMachineItems
    {
        
        public override string ConsumedSound()
        {
            return "Chew,Chew, Yum!";
        }

        public GumType(string location, string productName, decimal price, string productType)
            : base(location, productName, price, productType)
        {

        }
    }
}
}
