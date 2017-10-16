using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace SecretSanta.Tests
{
    [TestClass()]
    public class SecretSantaToolsTests
    {
        [TestMethod()]
        public void ShortShuffleNamesTest()
        {
            var listOfPersons = new List<Person>()
            {
                { new Person("Tash", "Jamie") },
                { new Person("Jamie", "Tash") },
                { new Person("Peri", "Tom") },
                { new Person("Tom", "Peri") }
            };

            List<Person> listOfShuffledPersons = SecretSantaTools.ShuffleNames(listOfPersons);

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Console.WriteLine($"{listOfPersons[i]} buys for {listOfShuffledPersons[i]}");
            }

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Assert.AreNotEqual(listOfPersons[i], listOfShuffledPersons[i]);
            }
        }

        [TestMethod()]
        public void LongShuffleNamesTest()
        {
            var listOfPersons = new List<Person>()
            {
                { new Person("Alex", "Jo") },
                { new Person("Alice", "Jim") },
                { new Person("Debie", "Nick") },
                { new Person("Tash", "Jamie") },
                { new Person("Jamie", "Tash") },
                { new Person("Jim", "Alice") },
                { new Person("Jo", "Alex") },
                { new Person("Katy", "Richard") },
                { new Person("Nick", "Debbie") },
                { new Person("Peri", "Tom") },
                { new Person("Richard", "Katy") },
                { new Person("Sophie", "None") },
                { new Person("Tom", "Peri") }
            };

            List<Person> listOfShuffledPersons = SecretSantaTools.ShuffleNames(listOfPersons);

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Console.WriteLine($"{listOfPersons[i]} buys for {listOfShuffledPersons[i]}");
            }

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Assert.AreNotEqual(listOfPersons[i], listOfShuffledPersons[i]);
            }
        }
     
        [TestMethod()]
        public void SwitchBuyerNamesTest()
        {
            // Arrange
            var list1 = new List<Person>()
            {
                { new Person("A", "a") },
                { new Person("B", "b") },
                { new Person("C", "c") }
            };

            var list2 = new List<Person>()
            {
                { new Person("C", "c") },
                { new Person("A", "a") },
                { new Person("B", "b") }
            };

            // Act
            SecretSantaTools.SwitchBuyerNames(list1, list2, "A", "B");

            SecretSantaTools.PrintResults(list1, list2);

            // Assert
            Assert.IsTrue(list1[0].Name == "A" && list2[0].Name == "B");
        }
    }
}