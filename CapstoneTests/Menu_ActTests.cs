using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class Menu_Act_Test
    {
        [TestMethod]
        public void Act_Works()
        {
            //Arrange
            int inputA = 0;
            int inputB = -2;
            int inputC = 5;

            //Act
            bool resultA = Menu_Act.Act(inputA);
            bool resultB = Menu_Act.Act(inputB);
            bool resultC = Menu_Act.Act(inputC);
           
            //Assert
            Assert.AreEqual(true, resultA, "Should return true");
            Assert.AreEqual(true, resultB, "Should return true");
            Assert.AreEqual(true, resultC, "Should return true");
        }

        [TestMethod]
        public void Act_Works_With_Min_Value()
        {
            //Arrange
            int inputA = int.MinValue;

            //Act
            bool resultA = Menu_Act.Act(inputA);
           
            //Assert
            Assert.AreEqual(true, resultA, "Should return true");
        }

        [TestMethod]
        public void Act_Works_With_Max_Value()
        {
            //Arrange
            int inputA = int.MaxValue;

            //Act
            bool resultA = Menu_Act.Act(inputA);
           
            //Assert
            Assert.AreEqual(true, resultA, "Should return true");
        }
    }
}
