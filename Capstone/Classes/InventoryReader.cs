using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Capstone.Classes
{
    public class InventoryReader

    { 
        

        public Dictionary<string, VendingMachineItems> ReadInventory()
        {
            Dictionary<string, VendingMachineItems> inventory = new Dictionary<string, VendingMachineItems>();

            using (StreamReader sr = new StreamReader(@"\Users\Mariah Dawson\Pairs\c-module-1-capstone-team-4\Capstone\Classes\vendingmachine.csv"))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');

                    if (values[3] == "Chip")
                    {
                        ChipsType chip = new ChipsType(values[0], values[1], decimal.Parse(values[2]), values[3]);
                        inventory.Add(values[0], chip);
                    }
                    //...

                   
                }


            }

            return inventory;
        }


    }
}
