using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void isValid_Works()
        {
            //Arrange
            int inputA = 1;
            int[] ArrayA = new int[] { 1, 2, 4 };
            int inputB = 0;
            int[] ArrayB = new int[] { 1, 0, 4 };
            int inputC = -5;
            int[] ArrayC = new int[] { 1, 2, -5 };
            int inputD = 5;
            int[] ArrayD = new int[] { 1, 3, -5 };

            //Act
            bool resultA = Validation.isValid(inputA, ArrayA);
            bool resultB = Validation.isValid(inputB, ArrayB);
            bool resultC = Validation.isValid(inputC, ArrayC);
            bool resultD = Validation.isValid(inputD, ArrayD);

            //Assert
            Assert.AreEqual(true, resultA, "Should return true");
            Assert.AreEqual(true, resultA, "Should return true");
            Assert.AreEqual(true, resultA, "Should return true");
            Assert.AreEqual(false, resultD, "Should return false");

        }

        [TestMethod]
        public void IsValid_With_Max_Int()
        {
            //Arrange
            int inputA = int.MaxValue;
            int[] ArrayA = new int[] { 1, 2, int.MaxValue };

            //Act
            bool resultA = Validation.isValid(inputA, ArrayA);

            //Assert
            Assert.AreEqual(true, resultA, "Should return true");

        }

        [TestMethod]
        public void IsValid_With_Min_Int()
        {
            //Arrange
            int inputA = int.MinValue;
            int[] ArrayA = new int[] { 1, 2, int.MinValue };

            //Act
            bool resultA = Validation.isValid(inputA, ArrayA);

            //Assert
            Assert.AreEqual(true, resultA, "Should return true");

        }

        [TestMethod]
        public void IsValid_With_Null()
        {
            //Arrange
            int inputA = 5;
            int[] ArrayA = null;

            //Act
            bool resultA = Validation.isValid(inputA, ArrayA);

            //Assert
            Assert.AreEqual(false, resultA, "Should return false");

        }

        [TestMethod]
        public void Exit_Works()
        {
            //Arrange
            string inputA = "no exit";
            string inputB = "n   exit";

            //Act
            int resultA = Validation.exit(inputA);
            int resultB = Validation.exit(inputB);

            //Assert
            Assert.AreEqual(0, resultA, "Should return 0");
            Assert.AreEqual(0, resultB, "Should return 0");
        }

        [TestMethod]
        public void Exit_Works_With_Null()
        {
            //Arrange
            string inputA = null;

            //Act
            int resultA = Validation.exit(inputA);

            //Assert
            Assert.AreEqual(0, resultA, "Should return 0");

        }
    }
}
