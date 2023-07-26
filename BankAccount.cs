using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; private set; }
    public string AccountHolderName { get; private set; }
    public double balance; // Private field to store the balance

    // Constructor
    public BankAccount(string accountHolderName)
    {
        AccountNumber = GenerateAccountNumber();
        AccountHolderName = accountHolderName;
        balance = 0;
    }

    // Method to generate a unique account number
    private string GenerateAccountNumber()
    {
        // In a real-world scenario, this could be a more sophisticated algorithm.
        // For this demonstration, we'll simply use a sequential number prefixed with "ACC".
        string accountNumber = "ACC" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        return accountNumber;
    }

    // Method to deposit an amount into the account
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        balance += amount;
    }

    // Method to withdraw an amount from the account
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        balance -= amount;
    }
}

