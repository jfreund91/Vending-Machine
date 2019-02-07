using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Logger
    {
        public void Log()
        { 
            using (StreamWriter sw = new StreamWriter("Log.txt"))
            {
                //TODO
                sw.WriteLine($"{DateTime.Now}");
            }
        }
    }
}
