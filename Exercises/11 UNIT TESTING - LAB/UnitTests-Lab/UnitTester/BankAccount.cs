using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (Balance < amount)
        {
            throw new ArgumentException("Not enougth money");
        }

        this.Balance -= amount;
    }
}

