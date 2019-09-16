using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bonus
{
    public class BankAccount
    {
        public decimal AnnualRate // Annual Interest Rate as a decimal
        {
            get
            {
                return annualRate;
            }
            set
            {
                if (value < 0)
                {
                    annualRate = 0.05m;
                }
                else
                {
                    annualRate = value;
                }
            }
        }

        public decimal Balance // Account Balance as a decimal
        {
            get
            {
                return balance;
            }
        }


        private decimal annualRate;
        protected decimal balance;

        /// <summary>
        /// Bank Account constructor that takes balance and annual rate and sets specified values if less than zero.
        /// </summary>
        /// <param name="Balance"> Account Balance </param>
        /// <param name="AnnualRate"> Annual Interest Rate </param>
        public BankAccount(decimal Balance, decimal AnnualRate)
        {
            if (Balance < 0)
            {
                balance = 0;
            }
            else
            {
                balance = Balance;
            }
            this.AnnualRate = AnnualRate;
        }

        /// <summary>
        /// Calculates new account balance if an amount is deposited.
        /// </summary>
        /// <param name="amount"> decimal amount being deposited </param>
        /// <returns> Updated account balance and bool value </returns>
        public bool Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Calculates new account balance if an amount is withdrawn.
        /// </summary>
        /// <param name="amount"> decimal amount being withdrawn </param>
        /// <returns> Updated account balance and bool value </returns>
        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= balance && amount >= 0)
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
        /// Calculates monthly interest and adds it to account balance.
        /// </summary>
        public virtual void AddMonthlyInterest()
        {
            balance += (balance * (annualRate / 12m));
        }

        /// <summary>
        /// Override ToString() method to give summary of balance and annual interest rate.
        /// </summary>
        /// <returns> Summary of balance and annual interest rate as a string. </returns>
        public override string ToString()
        {
            return ($"Your account balance is {balance} and annual interest rate is {annualRate * 100}%.");
        }
    }
}
