using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        private VendingMachineBrain vm;
        List<VendingMachineItem> cartItems = new List<VendingMachineItem>();
        public void Run()
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Purchase Menu:");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine($"Current Money Provided: {vm.Balance:C}");
                //visual of added items in cart
                //DisplayCart();

                Console.WriteLine("(Q) Quit ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Enter the amount you'd like to add(In Dollars, No Change!):");
                    decimal addedMoney = decimal.Parse(Console.ReadLine());
                    vm.FeedMoney(addedMoney);
                    Console.WriteLine($"Added {addedMoney} to your balance.");
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Enter your selection slot:");
                    string selection = Console.ReadLine();

                    if (vm.Balance >= vm.SeeItemAt(selection).Price&& vm.Slots.Contains(selection))
                    {
                        vm.SeeItemAt(selection).RemoveItem();
                        cartItems.Add(vm.SeeItemAt(selection));
                        Console.WriteLine("Your item has been added to the cart.");
                        Console.WriteLine();
                    }
                    else if(vm.Slots.Contains(selection)&& vm.Balance < vm.SeeItemAt(selection).Price)
                    {
                        Console.WriteLine("Please enter more money");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                }
                else if (choice == "3")
                {
                    //Calls method to issue change and write the consumed noise.
                }
                else if (choice == "Q" || choice == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }
            }
        }
        public void DisplayCart()
        {
     
            foreach(VendingMachineItem item in cartItems)
            {
                Console.WriteLine($"{item.ProductName} ----- {item.Price}");
              
            }
        }
        public void AddToCart(VendingMachineItem itemToAdd)
        {
            cartItems.Add(itemToAdd);
        }
        public PurchaseMenu(VendingMachineBrain vm)
        {
            this.vm = vm;
        }
    }

    
}
