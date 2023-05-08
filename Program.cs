namespace Prog_124_Practice_Virtual_Overriding_New
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            BankAccount bASA = new SavingsAccount("Nami", rand.Next(), 10000);
            BankAccount bCSA = new CheckingAccount("Jonathan", rand.Next(), 900, 0);
            BankAccount bRA = new RetirementAccount("Jonathan", rand.Next(), 900, 0);
            SavingsAccount savingsAccount = new SavingsAccount("Nami", rand.Next(), 10000);
            CheckingAccount checkingAccount = new CheckingAccount("Jonathan", rand.Next(), 900, 0);
            RetirementAccount ret = new RetirementAccount("Jonathan", rand.Next(), 900, 0);
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new SavingsAccount("Nami", rand.Next(), 10000),
                new CheckingAccount("Jonathan", rand.Next(), 900, 10),
                new RetirementAccount("Jonathan", rand.Next(), 900, 0)
            };

            bankAccounts.Add(savingsAccount);
            bankAccounts.Add(checkingAccount);
            bankAccounts.Add(ret);
            bASA.Deposit(500);
            bASA.Deposit(-50000);
            bASA.Withdraw(200);
            bASA.Withdraw(-200000);
            bCSA.Deposit(500);
            bCSA.Deposit(-50000);
            bCSA.Withdraw(200);
            bCSA.Withdraw(-200000);
            bRA.Deposit(500);
            bRA.Deposit(-50000);
            bRA.Withdraw(200);
            bRA.Withdraw(-200000);
            savingsAccount.Withdraw(100000);
            checkingAccount.Withdraw(100000);
            ret.Withdraw(200);
            foreach(BankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine(bankAccount.ToString());
            }
        }
    }
}