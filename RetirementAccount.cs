using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Virtual_Overriding_New
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, int accountNumber, double balance, double interest = 0.1) : base(name, accountNumber, balance, interest)
        {
        }

        public bool NewWithdraw(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Cannot Withdraw from a retirement account");
                return false;
            }
            return false;
        }
    }
}
