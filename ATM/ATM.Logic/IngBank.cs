using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class IngBank:Bank
    {

        public override string GenerateBankAccountNumber()
        {
            return "ING-AZERTYUI";
        }

    }
}
