﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Capstone.Classes
{
    /// <summary>
    /// Represents our purchase UI menu.
    /// </summary>
    public class PurchaseMenu
    {
        private VendingMachineBrain vm;

        private Logger log;
       
        public void Run()
        {
            while (true)
            {            
                vm.DisplayStock();
                Console.WriteLine("Purchase Menu:");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine($"Current Money Provided: {vm.Balance:C}");
                Console.WriteLine($"Grand Total in cart: {vm.GrandTotal:C}");
                Console.WriteLine("(Q) Quit ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    vm.DisplayStock();
                    Console.WriteLine("Enter the amount you'd like to add(In Dollars, No Change!):");
                    string input = Console.ReadLine();
                    decimal dollars;
                    bool inputToDollars = decimal.TryParse(input, out dollars);
                    
                    Console.Clear();
                    vm.FeedMoney(dollars);
                    log.InputLog(dollars);                    
                   
                }
                else if (choice == "2")
                {
                    Console.Clear();

                    string[] slots = vm.Slots;
                    vm.DisplayStock();

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

                    if (vm.GrandTotal > vm.Balance)
                    {
                        Console.WriteLine("Please Feed more money");
                    }
                    else
                    {
                        log.OutputLog();
                        vm.Charge();
                        vm.Change();
                        vm.ClearCart();
                        log.SalesAudit();
                        Console.WriteLine();
                    }
                }

                else if (choice == "Q" || choice == "q")
                {
                    if (vm.Cart.Count > 0 && vm.Balance > 0 )
                    {
                        vm.Cart.Clear();
                        vm.Change();
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }               
             }
        }
       
        public PurchaseMenu(VendingMachineBrain vm, Logger log)
        {
            this.vm = vm;
            this.log = log;
        }
    }
}
