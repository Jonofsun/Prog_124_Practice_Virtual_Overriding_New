using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Virtual_Overriding_New
{
    internal class CheckingAccount : BankAccount
    {
        double _overdraftFee;

        public CheckingAccount(string name, int accountNumber, double balance, double overdraftFee): base(name, accountNumber, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        public override bool Withdraw(double amount)
        {
            bool withdraw = base.Withdraw(amount);
            if (!withdraw)
            {
                Balance -= _overdraftFee;
            }
            return withdraw;
        }
        public override string ToString()
        {
            return base.ToString() + $" Added Fee: {_overdraftFee}";
        }
    }
}
