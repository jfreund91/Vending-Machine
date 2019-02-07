using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Capstone.Classes
{
    public class InventoryReader
    {
        public static void ReadInventory()
        {
            using (StreamReader sr = new StreamReader("vendingmachine.csv"))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
            }
        }
    }
}
