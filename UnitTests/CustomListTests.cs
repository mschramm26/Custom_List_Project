using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List_Project;

namespace UnitTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void TestItemAtIndexZero()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;

            // Act
            list.Add(8);
            int actual = list[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // fails because i haven't set up Count yet
        public void TestCountsOfItemsInArray()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            // Act
            list.Add(123);
            int actual = list.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove()
        {
            // Arrange
            CustomList<double?> list = new CustomList<double?>();
            double? expected = null;

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(3);
            double? actual = list[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestingNegativeNumber()
        //{
        //    // Arrange
        //    CustomList<int> list = new CustomList<int>() { 10, -5, -1 };
        //    int expected = 4;

        //    // Act
        //    int actual = list[0] + list[1] + list[2];

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestingDecimal()
        //{
        //    // Arrange
        //    CustomList<int> list = new CustomList<int>() { 7 };
        //    double expected = 7.25;

        //    // Act
        //    double actual = list[0] + 0.25;

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
