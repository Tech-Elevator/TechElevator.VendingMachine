using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class Action_DisplayVendingMachineItems_Tests
    {
        [TestMethod]
        public void DisplayVendingMachineItems_Test()
        {
            Assert.AreEqual(Action_DisplayVendingMachineItems.DisplayVendingMachineItems(), -1, "should return -1 if reached the end of method");
        }

    }
}
