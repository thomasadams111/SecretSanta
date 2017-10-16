using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    public class Person
    {
        public Person(string name, string partnerName) : this(name, partnerName, "")
        {
        }

        public Person(string name, string partnerName, string wishList)
        {
            this.Name = name;
            this.Partner = partnerName;
            this.WishList = wishList;
        }

        public string Name { get; set; }
        public string Partner { get; set; }
        public string WishList { get; set; }

        public string Print()
        {
            var personString = $"Name: {this.Name}, Partner: {this.Partner}";
            Console.WriteLine(personString);

            return personString;
        }
            
        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(Object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
                return false;
            else
                return Name.Equals(personObj.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool EqualsPartner(Object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
                return false;
            else
                return Partner.Equals(personObj.Name);
        }

        public bool notAllowed(object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
                return false;
            else
                return (Name.Equals(personObj.Name) || Partner.Equals(personObj.Name));
        }
    }

    
}
