using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTests
    {
        [TestMethod]
        public void RemoveFromStockWorks()
        {
            //Arrange
            Product inputProduct = new Product("A2", "Stackers", 1.50M, "Chips");

            //Act
            bool resultInput = Inventory.RemoveFromStock(inputProduct);

            //Assert
            Assert.AreEqual(true, resultInput, "Should return true");
        }

        [TestMethod]
        public void AddWorks()
        {
            //Act
            bool resultInput = Inventory.Add();

            //Assert
            Assert.AreEqual(true, resultInput, "Should return true");
        }
    }
}
