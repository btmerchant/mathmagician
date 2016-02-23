using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntergerEnsureICanCreateAnInstance()
        {
            IntegerTests my_int = new IntegerTests();
            Assert.IsNotNull(my_int);
        }
        //use testm tab tab
        [TestMethod]
        public void IntegerInsureICanGetFirstNumber()
        {
            // Arange -Scenario Setup
            IntegerTests my_int = new IntegerTests();
            // Act - Do the thing you want to test
            int actual = my_int.GetFirst();
            int expected = 0;
            // Assert did it work as expected
            Assert.AreEquals(expected, actual);
        }
        [TestMethod]
        public void IntegerEnsureICanGetNextInteger()
        {
            // Arange -Scenario Setup
            IntegerTests my_int = new IntegerTests();
            // Act - Do the thing you want to test
            int actual = my_int.GetNext(5);
            int expected = 6;
            // Assert did it work as expected
            Assert.AreEquals(expected, actual);
        }
        [TestMethod]
        public void IntegerEsureICanCreateASequenceOfTenIntegers()
        {
            //Look at MSDN CollectionAssert class ie AreEqual
            // Arange -Scenario Setup
            IntegerTests my_int = new IntegerTests();
            // Act - Do the thing you want to test
            int[] actual = my_int.GetSequence();
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Assert did it work as expected
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof)]
        public void IntegerInsureMaxIsNotExceded()
        {
            // Arange -Scenario Setup
            IntegerTests my_int = new IntegerTests();
            // Act - Do the thing you want to test
            int[] actual = my_int.GetSequence(some_int);
            Assert.Throws(typeof(Exception))
        }
    }
}
