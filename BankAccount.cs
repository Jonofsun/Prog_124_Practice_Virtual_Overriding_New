using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Virtual_Overriding_New
{
    public class BankAccount
    {
        string _name;
        int _accountNumber;
        double _balance;

        public BankAccount(string name, int accountNumber, double balance)
        {
            Random rand = new Random();
            int rInt = rand.Next(0, 100);
            _name = name;
            _accountNumber = rInt;
            _balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance; set => _balance = value; }
        public virtual bool Deposit(double amount)
        {
            if(amount > 0)
            {
                _balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if(amount > 0 && _balance >= amount)
            {
                return true;
            }
            else { return false; }
        }
        public override string ToString()
        {
            return $"{this.GetType().ToString()} - {_name} - {_accountNumber} - {_balance}";
            var test = this.GetType().ToString() ;
        }
    }
}
