using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSanta
{
    public static class SecretSantaTools
    {
        public static List<Person> GetPeople()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Tom\source\repos\SecretSanta\Names.txt");
            var listOfPersons = new List<Person>();

            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                listOfPersons.Add(new Person(words[0], words[1], words[2]));
            }
            return listOfPersons;
        }

        public static List<Person> ShuffleNames(List<Person> listOfPersons)
        {
            var listOfShuffledPersons = listOfPersons;

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                if (listOfPersons[i].notAllowed(listOfShuffledPersons[i]))
                {
                    listOfShuffledPersons = listOfPersons
                                          .OrderBy(a => Guid.NewGuid())
                                          .ToList();
                    i = 0;
                }
            }

            return listOfShuffledPersons;
        }

        // Can cause people to buy for themselfs or partners due to switch
        public static void SwitchBuyerNames(List<Person> listOfPersons, List<Person> listOfShuffledPersons, string name1, string name2)
        {
            // index of katy in buying list
            var index1 = listOfPersons.FindIndex(a => a.Name == name1);
            // index of Jo in boughtforlist
            var index2 = listOfShuffledPersons.FindIndex(a => a.Name == name2);

            var tmp = listOfShuffledPersons[index1].Name;
            listOfShuffledPersons[index1].Name = name2;
            listOfShuffledPersons[index2].Name = tmp;

            for (int i = 0; i < listOfPersons.Count; i++)
            {
                if (listOfPersons[i].notAllowed(listOfShuffledPersons[i]))
                    Console.WriteLine("Error while running Kluge for Switch Names Rerun");
            }
        }

        public static void PrintResults(List<Person> listOfPersons, List<Person> listOfShuffledPersons)
        {
            Console.WriteLine("These are the results...");
            //System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("...");
                //System.Threading.Thread.Sleep(100);
            }
            Console.Write("\r\n");
            for (int i = 0; i < listOfPersons.Count; i++)
            {
                Console.WriteLine($"{listOfPersons[i]} buys for {listOfShuffledPersons[i]}\r\n" +
                    $"\tThey would like: {listOfShuffledPersons[i].WishList}");
                //System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
