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
            switch(dollars)
            {
                case (1M):
                    this.Balance += 1;
                    break;
                case (2M):
                    this.Balance += 2;
                    break;
                case (5M):
                    this.Balance += 5;
                    break;
                case (10M):
                    this.Balance += 10;
                    break;
                default:
                    Console.WriteLine("Invalid Entry, No MONEY ADDED.");
                    break;
            }
            Console.WriteLine($"{Balance:C2} is your current balance.");
        }

        public void DisplayCartItems()
        {
            foreach (VendingMachineItem item in Cart)
            {
                Console.WriteLine($"{item.ProductName}=={item.Price:C}");
            }
            Console.WriteLine($"Grand Total:{this.GrandTotal:C}");
            
        }

        public void DisplayStock()
        {
            string[] slots = Slots;
            foreach (string slot in slots)
            {
                VendingMachineItem currentItem = SeeItemAt(slot);
                Console.WriteLine($"{currentItem.Location}   ||   {currentItem.ProductName.PadRight(20)}   ||  {currentItem.Price:C}  || {currentItem.Quantity}");

            }
        }
        public void ClearCart()
        {
            foreach(VendingMachineItem item in Cart)
            {
                Console.WriteLine(item.ConsumedSound());
            }
            Cart.Clear();
            //this.Balance = 0;
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
            this.Balance = 0M;
        }
        public void AddToCart(string selection)
        {
            if (SeeItemAt(selection).Quantity > 0)
            {
                SeeItemAt(selection).RemoveItem();
                Cart.Add(SeeItemAt(selection));

                Console.Clear();
                Console.WriteLine("Your item has been added to the cart.");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Sorry, we are sold out. Please choose another item!");
        }
        

    }
}
