using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Virtual_Overriding_New
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;

        public SavingsAccount(string name, int accountNumber, double balance, double interest = .1) : base(name, accountNumber, balance)
        {
            _interest = interest;
        }

        public double Interest { get => _interest; set => _interest = value; }
        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                base.Deposit(amount);
                Balance += (amount * _interest);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" Interest Added: {_interest}";
        }
    }
    
}
