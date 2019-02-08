using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests
{
    [TestClass]
    public class FeedMoneyTest
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

        public void FeedMoneyTest_InvalidBill_DoesNotProceed()
        {
            InventoryReader inventoryReader = new InventoryReader();
            Dictionary<string, VendingMachineItem> inventory = inventoryReader.ReadInventory();

            VendingMachineBrain badRoad = new VendingMachineBrain(inventory);
            badRoad.FeedMoney(8.75M);
            Assert.AreEqual(0, badRoad.Balance, "Balance should not be updated.");

        }
    }

    [TestClass]
    public class ChargeTest
    {
        [TestMethod]
        public void ChargeTest_RemovesProperAmount()
        {
            InventoryReader inventoryReader = new InventoryReader();
            Dictionary<string, VendingMachineItem> inventory = inventoryReader.ReadInventory();

            VendingMachineBrain happyRoad = new VendingMachineBrain(inventory);
            happyRoad.FeedMoney(5);
            happyRoad.AddToCart("A1");
            happyRoad.Charge();
            Assert.AreEqual(1.95M, happyRoad.Balance, "Item added updates the balance");
        }
    }


}
