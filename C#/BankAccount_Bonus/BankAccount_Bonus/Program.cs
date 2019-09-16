using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> BankAccounts = new List<BankAccount> ();
            BankAccounts.Add(new BankAccount(512.34m, 0.01m));
            BankAccounts.Add(new BankAccount(1799.87m, 0.02m));
            BankAccounts.Add(new BankAccount(1567254.12m, 0.05m));
            BankAccounts.Add(new CheckingAccount(4.08m, 0.01m, 0m));
            BankAccounts.Add(new CheckingAccount(500.83m, 0.02m, 500m));
            BankAccounts.Add(new CheckingAccount(18673091.53m, 0.05m, 5000m));

            foreach (BankAccount Account in BankAccounts)
            {
                Console.WriteLine(Account);
            }

            Console.ReadKey();
        }
    }
}
