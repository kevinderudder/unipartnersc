using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class KbcBank : Bank
    {

        public override string GenerateBankAccountNumber()
        {
            //return base.GenerateBankAccountNumber();
            //return "KBC-12345678";
            return "KBC-" + base.GenerateBankAccountNumber();
        }

    }
}
