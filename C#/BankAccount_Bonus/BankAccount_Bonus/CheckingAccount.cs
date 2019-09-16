using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bonus
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit // Checking account overdraft limit as a decimal
        {
            get
            {
                return overdraftLimit;
            }
            set
            {
                if (value <= 0)
                {
                    overdraftLimit = 500;
                }
                else
                {
                    overdraftLimit = value;
                }
            }
        }

        private decimal overdraftLimit;

        /// <summary>
        /// Checking Account constructor that inherits balance and annual rate from Bank Account Class and an Overdraft Limit.
        /// </summary>
        /// <param name="Balance"> Account Balance </param>
        /// <param name="AnnualRate"> Annual Interest Rate </param>
        /// <param name="OverdraftLimit"> Account Overdraft Limit </param>
        public CheckingAccount(decimal Balance, decimal AnnualRate, decimal OverdraftLimit) : base(Balance, AnnualRate)
        {
            this.OverdraftLimit = OverdraftLimit;
        }

        /// <summary>
        /// Calculates new checking account balance if an amount is withdrawn.
        /// </summary>
        /// <param name="amount"> decimal amount being withdrawn </param>
        /// <returns> Updated checking account balance and bool value </returns>
        public override bool Withdraw(decimal amount)
        {
            if (amount <= (balance + overdraftLimit) && amount > 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calculates monthly interest and adds it to checking account balance if the balance is greater than 0.
        /// </summary>
        public override void AddMonthlyInterest()
        {
            if (balance > 0)
            {
                base.AddMonthlyInterest();
            }
        }

        /// <summary>
        /// Override ToString() method to give summary of checking acount balance, annual interest rate and overdraft limit.
        /// </summary>
        /// <returns> Summary of checking acount balance, annual interest rate and overdraft limit as a string. </returns>
        public override string ToString()
        {
            return base.ToString() + ($" Also your overdraft limit on your Checking Account is {overdraftLimit}!");
        }
    }
}
