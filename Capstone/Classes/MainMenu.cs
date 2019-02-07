using System;
using System.Collections.Generic;
using System.Text;
using Capstone.Classes;
using System.IO;

namespace Capstone.Classes
{
    public class MainMenu
    {
        public void Run()

        {
            while(true)
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

                Console.WriteLine("Please make a choice.");
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(Q) Quit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    //TODO display menu vending machine class
                }
                if (choice == "2")
                {
                    //TODO 
                }
                if (choice == "Q" || choice == "q")
                {
                    break;
                }
               else
                {
                    Console.WriteLine("Invalid input.'");
                    Console.ReadLine();
                }

            }
        }
    }
}
