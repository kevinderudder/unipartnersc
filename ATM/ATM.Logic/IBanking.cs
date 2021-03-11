using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public interface IBanking
    {
        BankAccount CreateBankAccount();
        string GenerateBankAccountNumber();
    }
}
