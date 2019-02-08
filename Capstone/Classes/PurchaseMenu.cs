using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Capstone.Classes
{
    public class PurchaseMenu
    {
        private VendingMachineBrain vm;

        private Logger log;
       
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
                Console.WriteLine("(Q) Quit ");
                string choice = Console.ReadLine();

                //try {

                    if (choice == "1")
                    {
                        Console.WriteLine("Enter the amount you'd like to add(In Dollars, No Change!):");
                        decimal dollars = decimal.Parse(Console.ReadLine());
                        vm.FeedMoney(dollars);
                        log.InputLog(dollars);

                    }
                    else if (choice == "2")
                    {
                        Console.Clear();

                        string[] slots = vm.Slots;
                        foreach (string slot in slots)
                        {
                            VendingMachineItem currentItem = vm.SeeItemAt(slot);
                            Console.WriteLine($"{currentItem.Location}   ||   {currentItem.ProductName.PadRight(20)}   ||  {currentItem.Price:C}  || {currentItem.Quantity}");

                        }
                        Console.WriteLine("Enter your selection slot:");
                        string selection = Console.ReadLine().ToUpper();

                        if (vm.Balance >= vm.SeeItemAt(selection).Price && vm.Slots.Contains(selection))
                        {
                            vm.AddToCart(selection);
                        }
                        else if (vm.Slots.Contains(selection) && vm.Balance < vm.SeeItemAt(selection).Price)
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
                        Console.Clear();
                        vm.DisplayCartItems();
                        log.OutputLog();
                        vm.Charge();
                        vm.Change();
                        vm.ClearCart();
                        Console.WriteLine();

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
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    break;
                //}
             }
        }
       
        public PurchaseMenu(VendingMachineBrain vm, Logger log)
        {
            this.vm = vm;
            this.log = log;
        }
    }

    
}
