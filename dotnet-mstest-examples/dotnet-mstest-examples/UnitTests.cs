using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_mstest_examples
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AgeTest()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual(25, bob.Age);
        }

        [TestMethod]
        public void NameTest()
        {
            var bob = new Person("Bob", 25);
            Assert.AreEqual(25, bob.Age);
        }

        [DataRow("Bob", 25)]
        [DataRow("Bill", 35)]
        [TestMethod]
        public void DataRowAgeTest(string name, int age)
        {
            var bob = new Person(name, age);
            Assert.AreEqual(age, bob.Age);
        }
    }
}
