using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Logic
{
    public class InsufficientFundsException:Exception
    {
        public double RequestedAmount { get; set; }
        public double AvailableAmount { get; set; }

        public InsufficientFundsException() { }
        public InsufficientFundsException(double requestedAmount)
            : this(requestedAmount, 0)
        { }
        public InsufficientFundsException(double requestedAmount, double availableAmount) {
            RequestedAmount = requestedAmount;
            AvailableAmount = availableAmount;
        }
    }
}
