using System;

using System.Linq;

using System.Collections.Generic;
using System.Security.Cryptography;



public class build
{
    public static void Main()
    {
        //CreateAccount();

        MenuDisplay();


    }

    public static void CreateAccount()
    {
        string accountName;
        Console.Write($" input the name you want to use and create account  :  ");
        accountName = Console.ReadLine();

        Account newAccount = new Account();

        newAccount.Name = accountName;
        // newAccount.AccountNumber = Random.Shared.Next();
        newAccount.AccountNumber = RandomNumberGenerator.GetInt32(10000000, 99999999);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"account name : {newAccount.Name}");
        Console.WriteLine($"account number {newAccount.AccountNumber}");
        Console.WriteLine();
        Console.WriteLine("-----------------------------");

        // Account.Deposit(newAccount, Account);



    }


    public static void MenuDisplay()
    {
        string userChoice;
        bool isRunning = true;

        Console.WriteLine("what do you want to do ? ");
        Console.WriteLine("1. Deposit money");
        Console.WriteLine("2. Transfer money");
        Console.WriteLine("3. withdraw money");
        Console.WriteLine("4. check balance");
        Console.WriteLine("5. transaction history");
        Console.WriteLine("6. exit");

        userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Account.Deposit(newAccount.Name, Balance);
        }

        //  else if (userChoice == "2")
        //      {
        //         Account.Transfer();
        //    }







    }
}



public class Bank
{
    public List<string> TransactionHistory;





}

public class Account
{
    public string Name { get; set; }
    public int AccountNumber { get; set; }
    public decimal Balance = 0;

    public static decimal Deposit(Account newAccount, decimal Balance)
    {
        decimal amountToDeposit;
        Console.WriteLine($"{newAccount.Name}  how much do you want to deposit ?");
        amountToDeposit = decimal.Parse(Console.ReadLine());

        Balance += amountToDeposit;

        return Balance;


    }

}



public class Transactions
{
    public DateTime TransactionDate { get; set; }
    public string TransactionID { get; set; }
    public decimal TransactionAmount { get; set; }




}


// Source - https://stackoverflow.com/a/37804448

// Posted by Shivprasad Koirala, modified by community. See post 'Timeline' for change history

// Retrieved 2026-01-11, License - CC BY-SA 4.0




