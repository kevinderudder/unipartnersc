using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public static class Money
    {
        private static double rate = 1.19;
        public static double ConvertToDollar(double amount) {
            return amount * rate;
        }

    }
}
