using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachineBrain
    {
        public decimal Balance { get; private set; }

        private Dictionary<string, object> stock { get; }

        public string Slots
        {
            get
            {
                return null;
            }
        }

        public void DisplayItems()
        {
        
        }

        public void Purchase()
        {

        }

        public void FeedMoney(decimal dollars)
        {
        }


        public VendingMachineBrain(Dictionary<string, object> inventory)
        {
            
        }


    }
}
