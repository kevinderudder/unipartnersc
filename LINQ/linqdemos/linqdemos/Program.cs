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
            //DemoWithLinq();
            //DemoPeopleWithLastNameD();
            DemoPeopleFromGhent();
        }

        static void DemoWithoutLinq()
        {
            List<Person> people = database.GetPeople();

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Age < 40)
                {
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

        static void DemoWithLinq()
        {
            // LINQ --> language integrated query
            var query = from p in database.GetPeople()
                        where p.Age < 40 && p.City == "Kontich" || p.Gender == Gender.FEMALE
                        select p;

            var query2 = database.GetPeople().Where(p => p.Age < 40 && p.City == "Kontich" || p.Gender == Gender.FEMALE);

            foreach (Person p in query.ToList())
            {
                Console.WriteLine($" > {p.Fullname}");
            }

            foreach (Person p in query2.ToList())
            {
                Console.WriteLine($" > {p.Fullname}");
            }
        }

        static void DemoPeopleWithLastNameD()
        {
            var query = from p in database.GetPeople()
                        where GetLastName(p).StartsWith("d", StringComparison.CurrentCultureIgnoreCase)
                        orderby p.Age ascending, p.City ascending
                        select p;

            var query2 = database.GetPeople()
                                 .Where(p => GetLastName(p).StartsWith("d", StringComparison.CurrentCultureIgnoreCase))
                                 .OrderBy(p => p.Age)
                                 .OrderByDescending(p => p.City);

            foreach (Person p in query.ToList()) {
                Console.WriteLine($" > {p.Fullname}");
            }

        }

        static void DemoPeopleFromGhent() {
            var query = from p in database.GetPeople()
                        group p by p.City into PersonCity
                        orderby PersonCity.Key
                        select PersonCity;

            foreach (var cityGroup in query) {
                Console.WriteLine($"Key: {cityGroup.Key}");

                foreach (Person p in cityGroup) {
                    Console.WriteLine($" > {p.Fullname}");
                }
            }
        }

        static string GetLastName(Person p)
        {
            string[] stringParts = p.Fullname.Split(' ');
            string lastPart = stringParts[stringParts.Length - 1];
            return lastPart;
        }
    }
}
