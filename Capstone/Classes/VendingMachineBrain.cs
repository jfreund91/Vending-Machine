using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents our digital Vendo-matic 500.
    /// </summary>
    public class VendingMachineBrain
    {
        /// <summary>
        /// Represents the current amount of money inserted into the Vending Machine.
        /// </summary>        
        public decimal Balance { get; private set; }
        /// <summary>
        /// Represents the stock of the Vending Machine.
        /// </summary>
        private Dictionary<string, VendingMachineItem> stock;
        /// <summary>
        /// Represents the total cost of all the items in the Cart.
        /// </summary>
        public decimal GrandTotal
        {
            get
            {
                decimal total = 0;
                foreach (VendingMachineItem item in Cart)
                {
                    total += item.Price;
                }
                return total;
            }
        }
        /// <summary>
        /// Represents our Cart of delicious snacks.
        /// </summary>
        public List<VendingMachineItem> Cart = new List<VendingMachineItem>();
        /// <summary>
        /// Represents the bin/location of the Vending Machine Items.
        /// </summary>
        public string[] Slots
        {
            get
            {
                return stock.Keys.ToArray();
            }
        }
        /// <summary>
        /// Examines the properties of a specific Vending Machine Item at the input slot number.
        /// </summary>
        /// <param name="slot"></param>
        /// <returns></returns>
        public VendingMachineItem SeeItemAt(string slot)
        {
            return stock[slot];
        }
        /// <summary>
        /// Insert money into the Vending Machine. Must be in 1s, 2s, 5s, or 10s.
        /// </summary>
        /// <param name="dollars"></param>
        public void FeedMoney(decimal dollars)
        {
            switch (dollars)
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
        /// <summary>
        /// Displays the current items in the cart.
        /// </summary>
        public void DisplayCartItems()
        {
            foreach (VendingMachineItem item in Cart)
            {
                Console.WriteLine($"{item.ProductName}=={item.Price:C}");
            }
            Console.WriteLine($"Grand Total:{this.GrandTotal:C}");

        }
        /// <summary>
        /// Displays the items the Vending Machine has in stock.
        /// </summary>
        public void DisplayStock()
        {
            string[] slots = Slots;
            foreach (string slot in slots)
            {
                VendingMachineItem currentItem = SeeItemAt(slot);
                Console.WriteLine($"{currentItem.Location}   ||   {currentItem.ProductName.PadRight(20)}   ||  {currentItem.Price:C}  || {currentItem.Quantity}");
            }
        }
        /// <summary>
        /// Clears the current cart items.
        /// </summary>
        public void ClearCart()
        {
            foreach (VendingMachineItem item in Cart)
            {
                Console.WriteLine(item.ConsumedSound());
            }
            Cart.Clear();
        }
        /// <summary>
        /// Creates a Vending Machine. Requires inventory input(Dictionary).
        /// </summary>
        /// <param name="inventory"></param>
        public VendingMachineBrain(Dictionary<string, VendingMachineItem> inventory)
        {
            this.Balance = 0;
            this.stock = inventory;
        }
        /// <summary>
        /// This method charges the Balance for the total of the items to purchase.
        /// </summary>
        public void Charge()
        { 
            this.Balance -= GrandTotal;
        }
        /// <summary>
        /// This method distributes the change and resets the Balance to zero.
        /// </summary>
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
        /// <summary>
        /// Add an item at the input location(if it is instock) to the cart.
        /// </summary>
        /// <param name="selection"></param>
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
