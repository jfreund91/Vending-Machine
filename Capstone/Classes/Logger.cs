using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Capstone.Classes
{
    public class Logger
    {
        public VendingMachineBrain vm;
        /// <summary>
        /// Logs the FeedMoney() method activities.
        /// </summary>
        /// <param name="dollars"></param>
        public void InputLog(decimal dollars)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    sw.WriteLine($"{DateTime.Now,-5} FEED MONEY        {dollars,-10:C2}   {vm.Balance:C2}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine($"Error writing to log: {ex.Message}"); 
            }
            
        }
        /// <summary>
        /// Logs the transactions.
        /// </summary>
        public void OutputLog()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Log.txt", true))
                {
                    foreach (VendingMachineItem item in vm.Cart)
                    {
                        sw.WriteLine($"{DateTime.Now,-5} {item.ProductName} {item.Location,-10} {vm.Balance,-10:C2} {vm.Balance - item.Price:C2}");
                    }
                    sw.WriteLine($"{DateTime.Now,-5} GIVE CHANGE      {vm.Balance - vm.GrandTotal:C2}       $0.00");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }
        public Logger(VendingMachineBrain vm)
        {
            this.vm = vm;
        }
    }

}
