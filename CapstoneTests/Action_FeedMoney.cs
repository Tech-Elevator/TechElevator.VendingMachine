using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class Action_FeedMoney_Test
    {
        [TestMethod]
         public void FeedMoney_Test()
        {
            Assert.AreEqual(Action_FeedMoney.FeedMoney(0), 0, "should return 0 if broke out of loop and returned");
        }
    }
}