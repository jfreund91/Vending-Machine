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
        private Logger log;
        public void Run()
        {
            Console.WriteLine("====WELCOME to Vendo-Matic500====");
            Console.WriteLine("_________________________________");
            Console.WriteLine("|################################|");
            Console.WriteLine("||      ooOOOOoo      |##########|");
            Console.WriteLine("||     0000000000     |##|****|##|");
            Console.WriteLine("||     0   00   0     |##|[  ]|##|");
            Console.WriteLine("||     0oo0000oo0     |##########|");
            Console.WriteLine("||       o0oo0o       |##########|");
            Console.WriteLine("||        0000        |#|******|#|");
            Console.WriteLine("||====================|#|      |#|");
            Console.WriteLine("||                    |#|======|#|");
            Console.WriteLine("||  A1|  B2 | C3 | D4 |#| [---]|#|");
            Console.WriteLine("||====================|#|  (`) |#|");
            Console.WriteLine("||                    |#|______|#|");
            Console.WriteLine("||  A2 | B3 | C4 | D5 |##########|");
            Console.WriteLine("||====================|##########|");
            Console.WriteLine("|||||||||||||||||||||||##########|");
            Console.WriteLine("||||||||PUSH|||||||||||##########|");
            Console.WriteLine("||###############################|");
            Console.WriteLine("|--------------------------------|");
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
                    Console.Clear();
                    vm.DisplayStock();

                }
                else if (choice == "2")
                {
                    Console.Clear();
                    PurchaseMenu pm = new PurchaseMenu(vm, log);
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
        public MainMenu(VendingMachineBrain vm, Logger log)
        {        
                this.vm = vm;
                this.log = log;
        }
    }
}
