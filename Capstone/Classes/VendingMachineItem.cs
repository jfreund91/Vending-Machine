using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
   public class VendingMachineItem
    {
        public string Location { get; private set; }
        
        public string ProductName { get; private set; }

        public decimal Price { get; private set; }

        public string ProductType { get; private set; }

        public int Quantity { get; private set; }

        public void RemoveItem()
        {
            if (this.Quantity == 0)
            {
                Console.WriteLine("SOLD OUT");
            }
            else
            {
                this.Quantity--;
            }
        }

        public virtual string ConsumedSound()
        {
            return null;
        }
  
        public VendingMachineItem(string location, string productName, decimal price)
        {
            this.Location = location;
            this.ProductName = productName;
            this.Price = price;
            this.ProductType = this.ProductType;
            this.Quantity = 5;
        }
    }
}
