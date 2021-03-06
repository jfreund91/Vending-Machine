﻿using System;
using System.Collections.Generic;
using Capstone.Classes;

namespace Capstone
{
    class Program
    {
        /// <summary>
        /// Vending machine program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            InventoryReader inventoryReader = new InventoryReader();
            Dictionary<string, VendingMachineItem> inventory = inventoryReader.ReadInventory();
            VendingMachineBrain vm = new VendingMachineBrain(inventory);
            Logger log = new Logger(vm);
            MainMenu menu = new MainMenu(vm, log);
            menu.Run();
        }
    }
}
