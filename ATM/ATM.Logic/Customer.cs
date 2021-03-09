using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public sealed class Customer : Person
    {
        public string CustomerNumber { get; set; }
        public BankAccount BankAccount { get; private set; }
        public Bank Bank { get; set; }

        public Customer(string firstName, string lastName) 
            :base(firstName, lastName)
        {
        }

        public Customer(string firstName, string lastName, string customerNumber) 
            :base(firstName, lastName)
        {
            CustomerNumber = customerNumber;
        }

        public void AddBank(Bank b) {
            Bank = b;
        }

        public void CreateBankAccount() {
            string accountNumber = Bank.GenerateBankAccountNumber();
            BankAccount newBankAccount = new BankAccount(accountNumber);
            BankAccount = newBankAccount;
        }
    }

    // kan ik niet van overerven omdat customer een sealed class is
    //public class BelgianCustomer : Customer { 
        
    //}
}
