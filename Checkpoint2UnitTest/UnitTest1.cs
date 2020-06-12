using Checkpoint2;
using NUnit.Framework;
using System;

namespace Checkpoint2UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPerson()
        {
            var person = new Person("Sebastian", 32);
            var expectedName = "Sebastian";
            var expectedAge = 32;
            Assert.AreEqual(expectedName, person.Name);
            Assert.AreEqual(expectedAge, person.Age);
        }

        [Test]
        public void TestCompany()
        {
            var company = new Company("Maestro", 50);
            var expectedName = "Maestro";
            var expectedEmployeeCount = 50;
            Assert.AreEqual(expectedName, company.Name);
            Assert.AreEqual(expectedEmployeeCount, company.EmployeeCount);
        }

        [Test]
        public void TestEmployee()
        {
            var e = new Employee("Sebastian", 32, new DateTime(2020,9,7), new Company("Maestro", 50));
            var expectedName = "Sebastian";
            var expectedAge = 32;
            var expectedHireDate = new DateTime(2020, 9, 7);
            var expectedCompany = "Maestro";
            Assert.AreEqual(expectedName, e.Name);
            Assert.AreEqual(expectedAge, e.Age);
            Assert.AreEqual(expectedHireDate, e.HireDate);
            Assert.AreEqual(expectedCompany, e.MyCompany.Name);
        }

    }
}