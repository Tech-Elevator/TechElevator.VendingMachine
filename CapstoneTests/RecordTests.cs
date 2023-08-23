using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class RecordTests
    {
        [TestMethod]
        public void SetTotalSales_Test()
        {
            Assert.AreEqual(101M, Record.SetTotalSales("** $101"), "Returned" + Record.SetTotalSales() + "instead of 101");
            Assert.AreEqual(102M, Record.SetTotalSales("** $102"), "Returned" + Record.SetTotalSales() + "instead of 102");
        }

        [TestMethod]
        public void AddToLog_Works() 
        {
            //Arrange
            string inputA = "Ryan";
            decimal priceA = 100.00M;
            Product inputB = new Product ("R5", "RyanSoda", 10.00M, "Chips");  

            //Act
            bool resultA = Record.AddToLog(inputA, priceA);
            bool resultB = Record.AddToLog(inputB);

            //Assert
            Assert.AreEqual(true, resultA, "Should return true");
            Assert.AreEqual(true, resultB, "Should return true");
        }

   
        
    }
}
