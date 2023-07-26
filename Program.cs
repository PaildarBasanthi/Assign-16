using System;

public class Program
{
    public static void Main()
    {
        // Creating a bank account and making some transactions
        Console.WriteLine("Enter Account Holder Name");
        string accountHolderName = Console.ReadLine();
        BankAccount account = new BankAccount(accountHolderName);


        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
        Console.WriteLine($"Initial Balance: {account.balance}");

        account.Deposit(1000);
        Console.WriteLine($"Balance after deposit: {account.balance}");

        account.Withdraw(500);
        Console.WriteLine($"Balance after withdrawal: {account.balance}");

        try
        {
            account.Withdraw(700); // This will throw an exception due to insufficient funds
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

