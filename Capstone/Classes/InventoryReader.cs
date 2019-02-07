using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Capstone.Classes
{
    public class InventoryReader

    {
        public Dictionary<string,VendingMachineItems> Inventory { get; private set; }

        public static void ReadInventory()
        {
            using (StreamReader sr = new StreamReader(@"\Users\Mariah Dawson\Pairs\c-module-1-capstone-team-4\Capstone\Classes\vendingmachine.csv"))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');

                }


            }
        }


    }
}
