using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class GumType :VendingMachineItem
    {
        
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

