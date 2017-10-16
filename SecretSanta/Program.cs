using System;
using System.Collections.Generic;

namespace SecretSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = SecretSantaTools.GetPeople();

            List<Person> listOfShuffledPersons = SecretSantaTools.ShuffleNames(listOfPersons);

            SecretSantaTools.PrintResults(listOfPersons, listOfShuffledPersons);

            SecretSantaTools.SwitchBuyerNames(listOfPersons, listOfShuffledPersons, "Katy", "Jo");

            SecretSantaTools.PrintResults(listOfPersons, listOfShuffledPersons);

            Console.Write("\r\n");
            Console.Write("\r\n");
            Console.WriteLine("Happy Christmas");
        }
    }
}
