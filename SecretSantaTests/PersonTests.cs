using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecretSanta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonPrintTest()
        {
            // Arrange
            var person = new Person("Tom", "Peri");
            var expected = "Name: Tom, Partner: Peri";

            // Act
            var actual = person.Print();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            // Arrange
            var person = new Person("Tom", "Peri");
            var expected = "Tom";

            // Act
            var actual = person.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NotAllowedTest()
        {
            // Arrange
            var person1 = new Person("Tom", "Peri");
            var person2 = new Person("Tom", "Peri");
            var expected = true;

            // Act
            var actual = person1.notAllowed(person2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NotAllowedPartnerTest()
        {
            // Arrange
            var person1 = new Person("Tom", "Peri");
            var person2 = new Person("Peri", "Tom");
            var expected = true;

            // Act
            var actual = person1.notAllowed(person2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NotAllowedInverseTest()
        {
            // Arrange
            var person1 = new Person("Tom", "Peri");
            var person2 = new Person("Katy", "Richard");
            var expected = false;

            // Act
            var actual = person1.notAllowed(person2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}