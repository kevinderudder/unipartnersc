using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public abstract class Person
    {
        // fields of velden

        // properties of eigenschappen
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        // constructor
        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        // methodes

        // overrides
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
