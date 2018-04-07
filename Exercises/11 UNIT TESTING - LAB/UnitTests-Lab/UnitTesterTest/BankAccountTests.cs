using System;
using NUnit.Framework;

namespace UnitTesterTest
{
    public class BankAccountTests
    {

        [Test]
        public void BankAccountShouldIncreaseBalance()
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(10);
            //  Assert.That(bankAccount.Balance,Is.EqualTo(25));
            Assert.AreEqual(9, bankAccount.Balance);
        }

        [TestCase(10)]
        [TestCase(100)]
        [TestCase(-10)]
        public void WithdrawTestException(int amount)
        {
            var bankaccount = new BankAccount();
            Assert.Throws<ArgumentException>(() => bankaccount.Withdraw(amount));
        }
    }
}
