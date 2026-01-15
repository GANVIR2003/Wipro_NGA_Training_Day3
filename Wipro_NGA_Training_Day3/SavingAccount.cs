using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_NGA_Training_Day3
{
    public class SavingAccount:BankAccount
    {
        public SavingAccount(string accNumber, string pin, decimal initialBalance, decimal rate, string branchCode)
           : base(accNumber, pin, initialBalance, rate, branchCode)
        {
        }
        public decimal CalculateInterest()
        {
            return balance * (decimal)interestRate / 100;
        }
    }
}
