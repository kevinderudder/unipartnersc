using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public sealed class Customer : Person
    {
        public string CustomerNumber { get; set; }

        public Customer(string firstName, string lastName) 
            :base(firstName, lastName)
        {
        }

        public Customer(string firstName, string lastName, string customerNumber) 
            :base(firstName, lastName)
        {
            CustomerNumber = customerNumber;
        }
    }

    // kan ik niet van overerven omdat customer een sealed class is
    //public class BelgianCustomer : Customer { 
        
    //}
}
