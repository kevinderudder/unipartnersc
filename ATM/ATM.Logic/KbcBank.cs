﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class KbcBank : Bank, ICrypto
    {
        public void BuyCoins(int amount)
        {
            throw new NotImplementedException();
        }

        public override string GenerateBankAccountNumber()
        {
            //return base.GenerateBankAccountNumber();
            //return "KBC-12345678";
            return "KBC-" + base.GenerateBankAccountNumber();
        }

        public void SellCoins(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
