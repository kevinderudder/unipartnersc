using System;
using System.Collections.Generic;
using System.Linq;
namespace linqdemos
{
    class Program
    {
        static Db database = new Db();
        static void Main(string[] args)
        {
            DemoWithLinq();
        }

        static void DemoWithoutLinq() {
            List<Person> people = database.GetPeople();

            for (int i = 0; i < people.Count; i++) {
                if (people[i].Age < 40) { 
                    Console.WriteLine($" > {people[i].Fullname}");
                }
            }

            foreach (Person p in people)
            {
                if (p.Age < 40)
                {
                    Console.WriteLine($" > {p.Fullname}");
                }
            }

            
        }

        static void DemoWithLinq() {
            // LINQ --> language integrated query
            var query = from p in database.GetPeople()
                        where p.Age < 40 && p.City == "Kontich" || p.Gender == Gender.FEMALE
                        select p;

            foreach (Person p in query.ToList()) {
                Console.WriteLine($" > {p.Fullname}");
            }
        }
    }
}
