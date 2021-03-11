using System;
using System.Collections.Generic;
using System.Text;

namespace linqdemos
{
    public class Db
    {
        public List<Person> GetPeople() {
            List<Person> people = new List<Person>();
            people.Add(new Person() { 
                Fullname = "Kevin DeRudder",
                Age = 42,
                City = "Gent",
                Gender = Gender.MALE
            });

            people.Add(new Person() { 
                Fullname = "Kris Muylaert",
                Age = 24,
                City = "Kontich",
                Gender = Gender.MALE
            });

            people.Add(new Person() { 
                Fullname = "Piet Pannenkoek",
                Age = 55,
                City = "Tienen",
                Gender = Gender.OTHER
            });

            people.Add(new Person() { 
                Fullname = "Marie Curry",
                Age = 88,
                City = "Brussel",
                Gender = Gender.FEMALE
            });

            people.Add(new Person()
            {
                Fullname = "Elodie DeRudder",
                Age = 8,
                City = "Gent",
                Gender = Gender.FEMALE
            });

            return people;
        }
    }
}
