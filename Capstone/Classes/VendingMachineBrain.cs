using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Capstone.Classes
{
    public class VendingMachineBrain
    {
        public decimal Balance { get; private set; }

        private Dictionary<string, VendingMachineItem> stock;

        //maybe a runningPriceTotal to keep track of the grand total
        
        public List<VendingMachineItem> Cart { get; private set; }
        public decimal Change
        {
            get
            {
                return 0;
            }
        }

        public string[] Slots
        {
            get
            {
                return stock.Keys.ToArray();
            }
        }

        public VendingMachineItem SeeItemAt(string slot)
        {
            return stock[slot];
        }


        public void FeedMoney(decimal dollars)
        {
            this.Balance += dollars; //may need a if else or switch statement that limits the bills that can be added to the balance
        }

        public void DisplayCartItems()
        {
            //foreach (VendingMachineItem item in Cart)
            //{
            //    Console.WriteLine($"{item.ProductName}=={item.Price}");
            //}
        }

        public VendingMachineBrain(Dictionary<string, VendingMachineItem> inventory)
        {
            this.Balance = 0;
            this.stock = inventory;
            
        }
        


    }
}
