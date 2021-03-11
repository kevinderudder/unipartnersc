using System;
using System.Collections.Generic;
using System.Text;

namespace linqdemos
{
    public enum Gender
    {
        MALE,
        FEMALE,
        OTHER
    }

    public class Person
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public Gender Gender { get; set; }


        public override string ToString()
        {
            return Fullname;
        }
    }
}
