using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class AccountingTests
    {


        [TestMethod]
        public void Return_Change_Works()
        {
            //Arrange
            Accounting.MachineBalance = 5.65M;

            //Act
            decimal resultA = Accounting.ReturnChange();

            //Assert
            Assert.AreEqual(0.00M, resultA, "Should return 0.00");
        }

        [TestMethod]
        public void Return_Change_With_Min_Value()
        {
            //Arrange
            Accounting.MachineBalance = 1.00M;

            //Act
            decimal resultA = Accounting.ReturnChange();

            //Assert
            Assert.AreEqual(0.00m, resultA, "Should return 0.00");
        }

        [TestMethod]
        public void Return_Change_With_Max_Value()
        {
            //Arrange
            Accounting.MachineBalance = 500.00M;

            //Act
            decimal resultA = Accounting.ReturnChange();

            //Assert
            Assert.AreEqual(0.00m, resultA, "Should return 0.00");
        }
        //Do not need to test for null, Decimal.MaxValue, or Decimal.MinValue because FeedMoney() validates those conditions
    }

}
