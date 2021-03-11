using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class RevolutBank : IBanking, ICrypto
    {
        public void BuyCoins(int amount)
        {
            throw new NotImplementedException();
        }

        public BankAccount CreateBankAccount()
        {
            BankAccount ba = new BankAccount(GenerateBankAccountNumber());
            return ba;
        }

        public string GenerateBankAccountNumber()
        {
            return $"REVO-1234567KJHGF";
        }

        public void SellCoins(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
