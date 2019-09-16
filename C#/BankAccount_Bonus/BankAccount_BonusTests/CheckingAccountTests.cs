using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount_Bonus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Bonus.Tests
{
    [TestClass()]
    public class CheckingAccountTests
    {
        [TestMethod()]
        public void Positive_Balance_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal OverdraftLimit = 1000.00m;
            decimal WithdrawAmount = 1500.00m;


            CheckingAccount CheckingAccount = new CheckingAccount(Balance, AnnualRate, OverdraftLimit);

            // act
            bool result = CheckingAccount.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) (Balance - WithdrawAmount), (double) CheckingAccount.Balance, 0.0001);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void Negative_Balance_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal OverdraftLimit = 1000.00m;
            decimal WithdrawAmount = 4000.00m;

            CheckingAccount CheckingAccount = new CheckingAccount(Balance, AnnualRate, OverdraftLimit);

            // act
            bool result = CheckingAccount.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) Balance, (double) CheckingAccount.Balance, 0.0001);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Negative_WithdrawAmount_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal OverdraftLimit = 1000.00m;
            decimal WithdrawAmount = -40.00m;

            CheckingAccount CheckingAccount = new CheckingAccount(Balance, AnnualRate, OverdraftLimit);

            // act
            bool result = CheckingAccount.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) Balance, (double) CheckingAccount.Balance, 0.0001);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Calculate_CheckingAccount_AddMonthlyInterestTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.05m;
            decimal OverdraftLimit = 1000.00m;

            CheckingAccount CheckingAccount = new CheckingAccount(Balance, AnnualRate, OverdraftLimit);

            // act
            CheckingAccount.AddMonthlyInterest();

            // assert
            Assert.AreEqual((double) (Balance + (Balance * (AnnualRate / 12m))), (double) CheckingAccount.Balance, 0.0001);
        }

        [TestMethod()]
        public void Calculate_CheckingAccoung_Is_NegativeAddMonthlyInterestTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.05m;
            decimal OverdraftLimit = 1000.00m;
            decimal WithdrawAmount = 1000.00m;

            CheckingAccount CheckingAccount = new CheckingAccount(Balance, AnnualRate, OverdraftLimit);
            CheckingAccount.Withdraw(WithdrawAmount);
            
            // act
            CheckingAccount.AddMonthlyInterest();

            // assert
            Assert.AreEqual((double) (Balance - WithdrawAmount), (double) CheckingAccount.Balance, 0.0001);
        }
    }
}