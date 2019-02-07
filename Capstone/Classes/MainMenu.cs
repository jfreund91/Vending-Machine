using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using System.IO;

namespace Capstone.Classes
{
    public class MainMenu
    {
        private VendingMachineBrain vm;
        public void Run()

        {
            Console.WriteLine("WELCOME to Vendo-Matic500");
            Console.WriteLine("________________________");
            Console.WriteLine("||      ooOOOOoo      ||");
            Console.WriteLine("||     0000000000     ||");
            Console.WriteLine("||     0   00   0     ||");
            Console.WriteLine("||     0oo0000oo0     ||");
            Console.WriteLine("||       o0oo0o       ||");
            Console.WriteLine("||        0000        ||");
            Console.WriteLine("||____________________||");
            Console.WriteLine("||____________________||");
            Console.WriteLine("||  ====     _______  ||");
            Console.WriteLine("||  |()|     [     ]  ||");
            Console.WriteLine("||  ====     [_____]  ||");
            Console.WriteLine("||____________________||");
            Console.WriteLine("========================");
            while (true)
            {
                

                Console.WriteLine("Please make a choice.");
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(Q) Quit");
                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    
                    string[] slots = vm.Slots;
                    foreach(string slot in slots)
                    {
                        VendingMachineItem currentItem = vm.SeeItemAt(slot);
                        Console.WriteLine($"{currentItem.Location}   ||   {currentItem.ProductName.PadRight(20)}   ||  {currentItem.Price:C}");
                        
                    }
                   
                 
                }
                else if (choice == "2")
                {
                    PurchaseMenu pm = new PurchaseMenu(vm);
                    pm.Run();
                }
                else if (choice == "Q" || choice == "q")
                {
                    break;
                }
               else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                }

            }

        }
        public MainMenu(VendingMachineBrain vm)
        {
            this.vm = vm;
        }
    }
}
