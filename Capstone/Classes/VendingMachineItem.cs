using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
   public class VendingMachineItems
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

        public virtual string ConsumedSound()
        {
            return null;
        }
  
        public VendingMachineItems(string location, string productName, decimal price, string productType)
        {
            this.Location = location;
            this.ProductName = productName;
            this.Price = price;
            this.ProductType = productType;

            this.Quantity = 5;
        }
    }
}
