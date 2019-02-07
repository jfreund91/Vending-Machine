using System;
using System.Collections.Generic;
using Capstone.Classes;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryReader inventoryReader = new InventoryReader();
            Dictionary<string, VendingMachineItems> inventory = inventoryReader.ReadInventory();

            MainMenu menu = new MainMenu();
            menu.Run();
        }
    }
}
