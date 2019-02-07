using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
   abstract class VendingMachineItems
    {
        public string Location { get; private set; }
        
        public string ProductName { get; private set; }

        public decimal Price { get; private set; }

        public string ProductType { get; private set; }

        public int Quantity { get; private set; }

        public void RemoveItem()
        {
            this.Quantity--;
        }

        public abstract string ConsumedSound();
  

    }
}
