using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class BankAccount
    {
        // velden of fields
        private string accountNumber;
        //private string firstName;
        //private string lastName;
        private double deposit;
        private double savings;

        // eigenschappen of properties
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set {
                accountNumber = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Deposit {
            get {
                return deposit;
            }
            private set {
                if (value <= 0) { deposit = 0; }
                else { deposit = value; }
            }
        }
        public double Savings {
            get {
                return savings;
            }
            private set {
                if (value <= 0) { savings = 0; }
                else { savings = value; }
            }
        }

        // constructor
        public BankAccount(string accountNumber) {
            this.AccountNumber = accountNumber;
            this.Deposit = 0;
            this.Savings = 0;
        }

        // methodes
        public void AddToDeposit(double amount) {
            //this.Deposit = this.Deposit + amount;
            this.Deposit += amount;
        }

        public void AddToSavings(double amount) {
            this.Savings += amount;
        }

        public void WithdrawFromDeposit(double amount) {
            if (amount > this.Deposit)
            {
                //TODO: unsufficient funds
            }
            else {
                this.Deposit -= amount;
            }
        }

        public void WithdrawFromSavings(double amount) {
            if (amount > this.Savings)
            {
                //TODO: unsufficient funds
            }
            else {
                this.Savings -= amount;
            }
        }


        // overrides
        public override string ToString() {
            return $"Uw saldo bedraagt: \n Zichtrekening: {this.Deposit} \n Spaarrekening: {this.Savings}";
        }

        public override bool Equals(object obj)
        {
            BankAccount ba = obj as BankAccount;
            if (ba == null)
            {
                return false;
            }
            else if (ba.AccountNumber == this.AccountNumber)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
