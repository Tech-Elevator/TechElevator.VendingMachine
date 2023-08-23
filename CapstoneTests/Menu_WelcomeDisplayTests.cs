using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class Menu_WelcomeDisplayTests
    {
        [TestMethod]
        public void WelcomeDisplay_Works()
        {
            //Arrange
            int inputA = -5;
            int inputB = 5;

            //Act
            int resultA = Menu_WelcomeDisplay.WelcomeDisplay(inputA);
            int resultB = Menu_WelcomeDisplay.WelcomeDisplay(inputB);

            //Assert
            Assert.AreEqual(-5, resultA, "Should return 5");
            Assert.AreEqual(5, resultB, "Should return 5");

        }

        [TestMethod]
        public void WelcomeDisplay_Works_Min()
        {
            //Arrange
            int inputA = int.MinValue;

            //Act
            int resultA = Menu_WelcomeDisplay.WelcomeDisplay(inputA);

            //Assert
            Assert.AreEqual(int.MinValue, resultA, "Should return minValue");

        }

        [TestMethod]
        public void WelcomeDisplay_Works_Max()
        {
            //Arrange
            int inputA = int.MaxValue;

            //Act
            int resultA = Menu_WelcomeDisplay.WelcomeDisplay(inputA);

            //Assert
            Assert.AreEqual(int.MaxValue, resultA, "Should return maxValue");

        }
    }
}
