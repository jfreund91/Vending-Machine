using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void FeedMoneyTest_HappyRoad()
        {
            InventoryReader inventoryReader = new InventoryReader();
            Dictionary<string, VendingMachineItem> inventory = inventoryReader.ReadInventory();
          
            VendingMachineBrain happyRoad = new VendingMachineBrain(inventory);
            happyRoad.FeedMoney(5);
            Assert.AreEqual(5, happyRoad.Balance, "Balance should be updated to $5.");

        }
    }
}
