using System;
using dotnet_mstest_examples.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_mstest_examples.Tests
{
    [TestClass]
    public class SimpleUnitTests
    {
        [TestMethod]
        public void Simplest_Test()
        {
            const int one = 1;
            Assert.AreEqual(1, one);
        }

        [TestMethod]
        public void Age_Test()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual(25, bob.Age);
        }

        [TestMethod]
        public void Name_Test()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual("Bob", bob.Name);
        }

        [DataRow("Bob", 25)]
        [DataRow("Bill", 35)]
        [TestMethod]
        public void Data_Row_Age_Test(string name, int age)
        {
            var bob = new Person(name, age);
            Assert.AreEqual(age, bob.Age);
        }

        [DataRow(57)]
        [DataRow(-100)]
        [DataRow(21)]
        [TestMethod]
        public void Data_Row_Number_Test(int number)
        {
            Assert.AreEqual(21, number);
        }


        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Expected_Exception_Test()
        {
            // Do Something Arrange / Act

            //Expect an exception from the Act, no need to throw it like this usually as its a demo.
            throw new NotImplementedException("This is showing an exception can be a valid test result");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Expected_Exception_Failure_Test()
        {
            // Do Something Arrange / Act

            //Expect an exception from the Act, no need to throw it like this usually as its a demo.
            throw new NotImplementedException();
        }

        [TestMethod]
        [Timeout(1)] // Milliseconds
        public void Timeout_Test()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual(25, bob.Age);
        }


        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void Timeout_Infinite_Test()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual(25, bob.Age);
        }
    }
}