using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class Action_FinishTransaction_Tests
    {
        [TestMethod]
        public void FinishTransaction_Tests_Test()
        {
            Assert.AreEqual(Action_FinishTransaction.FinishTransaction(1), 1, "should return 1 if reached the end of method");
        }
    }
}