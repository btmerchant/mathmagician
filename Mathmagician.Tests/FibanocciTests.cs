using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonocciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanGetFirst()
        {
            // Arrange
            Fibonacci my_Fibonaccis = new Fibonacci();

            // Act
            int actual = my_Fibonaccis.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FibonacciEnsureICanGetANumber()
        {
            // Arrange
            Fibonacci my_Fibonacci = new Fibonacci();
            // Act
            int actual = my_Fibonacci.GetNth(5);
            int expected = 5;
            // Assert
            Assert.AreEqual(expected, actual);
        }
      
    }
}
