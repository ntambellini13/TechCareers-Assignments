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
    public class BankAccountTests
    {
        [TestMethod()]
        public void Positive_Amount_DepositTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal DepositAmount = 40.00m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            bool result = Account.Deposit(DepositAmount);

            // assert
            Assert.AreEqual((double) (Balance + DepositAmount), (double) Account.Balance, 0.0001);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void Negative_Amount_DepositTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal DepositAmount = -40.00m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            bool result = Account.Deposit(DepositAmount);

            // assert
            Assert.AreEqual((double) Balance, (double) Account.Balance, 0.0001);
            Assert.IsFalse(result);

        }

        [TestMethod()]
        public void Positive_Balance_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal WithdrawAmount = 40.00m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            bool result = Account.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) (Balance - WithdrawAmount), (double) Account.Balance, 0.0001);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void Negative_Balance_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal WithdrawAmount = 4000.00m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            bool result = Account.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) Balance, (double) Account.Balance, 0.0001);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Negative_WithdrawAmount_WithdrawTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.01m;
            decimal WithdrawAmount = -40.00m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            bool result = Account.Withdraw(WithdrawAmount);

            // assert
            Assert.AreEqual((double) Balance, (double) Account.Balance, 0.0001);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void Calculate_AddMonthlyInterestTest()
        {
            // arrange
            decimal Balance = 512.34m;
            decimal AnnualRate = 0.05m;

            BankAccount Account = new BankAccount(Balance, AnnualRate);

            // act
            Account.AddMonthlyInterest();

            // assert
            Assert.AreEqual( (double) (Balance + (Balance * (AnnualRate / 12m))), (double) Account.Balance, 0.0001);
        }
    }
}