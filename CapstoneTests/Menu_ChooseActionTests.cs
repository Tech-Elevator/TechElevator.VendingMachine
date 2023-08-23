using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class Menu_ChooseActionTests
    {
        [TestMethod]
        public void ChooseAction_Works()
        {
            //Arrange
            int inputA = 0;
            int inputB = -5;
            int inputC = 5;

            //Act
            int resultA = Menu_ChooseAction.ChooseAction(inputA);
            int resultB = Menu_ChooseAction.ChooseAction(inputB);
            int resultC = Menu_ChooseAction.ChooseAction(inputC);

            //Assert
            Assert.AreEqual(5, resultA, "Should return 5");
            Assert.AreEqual(5, resultB, "Should return 5");
            Assert.AreEqual(5, resultC, "Should return 5");

        }

        [TestMethod]
        public void ChooseAction_Works_Min_Value()
        {
            //Arrange
            int inputA = int.MinValue;

            //Act
            int resultA = Menu_ChooseAction.ChooseAction(inputA);

            //Assert
            Assert.AreEqual(5, resultA, "Should return 5");
        }

        [TestMethod]
        public void ChooseAction_Works_Max_Value()
        {
            //Arrange
            int inputA = int.MaxValue;

            //Act
            int resultA = Menu_ChooseAction.ChooseAction(inputA);

            //Assert
            Assert.AreEqual(5, resultA, "Should return 5");
        }
    }
}
