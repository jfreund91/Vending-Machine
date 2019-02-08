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

        public void InputLog(decimal dollars)
        {
            using (StreamWriter sw = new StreamWriter("LogTEST.txt", true))
            {
                sw.WriteLine($"{DateTime.Now, -5} FEED MONEY        {dollars,-10:C2}   {vm.Balance:C2}");
            }
        }

        public void OutputLog()
        {
            using (StreamWriter sw = new StreamWriter("LogTEST.txt", true))
            {  
                foreach(VendingMachineItem item in vm.Cart)
                {
                   sw.WriteLine($"{DateTime.Now, -5} {item.ProductName} {item.Location, -10} {vm.Balance,-10:C2} {vm.Balance - item.Price:C2}");
                }
                sw.WriteLine($"{DateTime.Now, -5} GIVE CHANGE      {vm.Balance - vm.GrandTotal:C2}       $0.00");
            }
        }

        public Logger(VendingMachineBrain vm)
        {
            this.vm = vm;
        }
    }

}
