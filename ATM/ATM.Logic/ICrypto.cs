using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public interface ICrypto
    {
        void BuyCoins(int amount);
        void SellCoins(int amount);
    }
}
