namespace Prog_124_Practice_Virtual_Overriding_New
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            BankAccount bA = new BankAccount("Jonathan", rand.Next(), 900);
            SavingsAccount savingsAccount = new SavingsAccount("Nami", rand.Next(), 10000);
            CheckingAccount checkingAccount = new CheckingAccount("Jonathan", rand.Next(), 900, 0);
            RetirementAccount ret = new RetirementAccount("Jonathan", rand.Next(), 900, 0);
            List<BankAccount> bankAccounts = new List<BankAccount>();

            bankAccounts.Add(savingsAccount);
            bankAccounts.Add(checkingAccount);
            bankAccounts.Add(ret);
            bA.Deposit(500);
            bA.Deposit(-50000);
            bA.Withdraw(200);
            bA.Withdraw(-200000);
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