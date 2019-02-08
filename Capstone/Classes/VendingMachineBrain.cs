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

        public decimal GrandTotal
        {
            get
            {
                decimal total = 0;
                foreach(VendingMachineItem item in Cart)
                {
                    total += item.Price;
                }
                return total;
            }
        }


        public List<VendingMachineItem> Cart = new List<VendingMachineItem>();
       
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
            foreach (VendingMachineItem item in Cart)
            {
                Console.WriteLine($"{item.ProductName}=={item.Price:C}");
            }
            Console.WriteLine($"Grand Total:{this.GrandTotal:C}");
        }
        public void ClearCart()
        {
            foreach(VendingMachineItem item in Cart)
            {
                Console.WriteLine(item.ConsumedSound());
            }
            Cart.Clear();
            this.Balance = 0;
        }
        public VendingMachineBrain(Dictionary<string, VendingMachineItem> inventory)
        {
            this.Balance = 0;
            this.stock = inventory;
            
        }
        public void Charge()
        {
            this.Balance -= GrandTotal;

        }
        public void Change()
        {
            int changeMaker =(int)(this.Balance * 100.00M);
            int anQuarter = 0;
            int anDime = 0;
            int anNickle = 0;
            while(changeMaker >= 25)
            {
                changeMaker -= 25;
                anQuarter++;
            }
            while(changeMaker >= 10)
            {
                changeMaker -= 10;
                anDime++;
            }
            while(changeMaker >= 5)
            {
                changeMaker -= 5;
                anNickle++;
            }
            Console.WriteLine($"Your change is {anQuarter} quarters, {anDime} dimes, and {anNickle} nickles.");

        }
        public void AddToCart(string selection)
        {
            if (SeeItemAt(selection).Quantity > 0)
            {
                SeeItemAt(selection).RemoveItem();
                Cart.Add(SeeItemAt(selection));
                Console.WriteLine("Your item has been added to the cart.");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Sorry, we are sold out. Please choose another item!");
        }
        

    }
}
