using System;
using System.Collections.Generic;
using FizzBuzz.Components;
using FizzBuzz.Components.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        public TestContext TestContext { get; set; }                       

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Loop_WhenDivisorLessThanZero_ShouldThrowArgumentOutofRange()
        {
            TestContext.WriteLine("Executing test '{0}.{1}'...", TestContext.FullyQualifiedTestClassName, TestContext.TestName);

            //Arrange
            var combinations = new List<Combination>
            {
                new Combination{Divisor = -3, Text = "Fizz"},
                new Combination{Divisor = 5, Text="Fizz"}
            };

            //Act
            FizzBuzzIterator.IterateLoop(combinations);

            //Assert is handled by the Expected Exception        
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Loop_WhenListIsNull_ShouldThrowArgumentNullException()
        {
            TestContext.WriteLine("Executing test '{0}.{1}'...", TestContext.FullyQualifiedTestClassName, TestContext.TestName);

            //Arrange

            //Act
            FizzBuzzIterator.IterateLoop(null);

            //Assert is handled by Expected Exception
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Loop_WhenCountIsLessThanOne_ShouldThrowArgumentNullException()
        {
            TestContext.WriteLine("Executing test '{0}.{1}'...", TestContext.FullyQualifiedTestClassName, TestContext.TestName);

            //Arrange

            //Act
            FizzBuzzIterator.IterateLoop(new List<Combination>());

            //Assert is handled by Expected Exception
        }        

        [TestMethod]
        public void Results_ValidResultReturned()
        {
            TestContext.WriteLine("Executing test '{0}.{1}'...", TestContext.FullyQualifiedTestClassName, TestContext.TestName);

            //Arrange
            var combinations = new List<Combination>
            {
                new Combination{Divisor = 3,Text="Fizz"},
                new Combination{Divisor = 5,Text="Buzz"}
            };

            //Act
            var results = FizzBuzzIterator.IterateLoop(combinations);            

            //Assert                     
            Assert.IsNotNull(results, "Test Failed - Results are null.");
            Assert.AreNotEqual(results, string.Empty, "Test Failed - Results are an empty string.");
            Assert.IsInstanceOfType(results, typeof(string), "Test Failed - Results are not of type string.");
        }
    }
}
