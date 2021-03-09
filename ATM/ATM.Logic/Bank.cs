using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class Bank
    {
        public string Title { get; set; }
        public string Address { get; set; }

        public BankAccount CreateBankAccount() {
            BankAccount newBankAccount = new BankAccount(GenerateBankAccountNumber());
            return newBankAccount;
        }

        public virtual string GenerateBankAccountNumber() {
            return "12345678";
        }

    }
}
