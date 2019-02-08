using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Capstone.Classes
{
    public class InventoryReader
    { 
        public Dictionary<string, VendingMachineItem> ReadInventory()
        {
            Dictionary<string, VendingMachineItem> inventory = new Dictionary<string, VendingMachineItem>();
            
            using (StreamReader sr = new StreamReader("vendingmachine.csv"))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] value = line.Split('|');

                    if (value[3] == "Chip")
                    {
                        ChipType chip = new ChipType(value[0], value[1], decimal.Parse(value[2]));
                        inventory.Add(value[0], chip);
                    }
                    if(value[3] == "Candy" )
                    {
                        CandyType candy = new CandyType(value[0], value[1], decimal.Parse(value[2]));
                        inventory.Add(value[0], candy);
                    }
                    if (value[3] == "Drink")
                    {
                       DrinkType drink = new DrinkType(value[0], value[1], decimal.Parse(value[2]));
                        inventory.Add(value[0], drink);
                    }
                    if (value[3] == "Gum")
                    {
                        GumType gum = new GumType(value[0], value[1], decimal.Parse(value[2]));
                        inventory.Add(value[0], gum);
                    }
                }
            }
            return inventory;
        }

    }
}
