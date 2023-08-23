using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class Action_SelectProduct_Test
    {
        [TestMethod]
        public void SelectProduct_Test()
        {
            Assert.AreEqual(Action_SelectProduct.SelectProduct(2), 2, "should return 2 if broke out of loop and returned");
        }

    }
}
