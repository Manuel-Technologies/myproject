using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using Microsoft.VisualBasic;


public class Program
{
    // BankAccount bankAccount = new BankAccount();
    double accountBalance = 0;
    
    public static void Main()
    {
        Console.WriteLine("what is the name you want to create the account with?");
        var userName = Console.ReadLine();
    
        // DisplayMenu()
        DisplayMenu(userName);
    }

    public static void DisplayMenu(string userName)
    {
        Console.WriteLine("welcome to novaPay ...where your finance matters");
        System.Console.WriteLine();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine();

        BankAccount account = new BankAccount();
        // account.balance = 

        account.name=userName;

        Console.WriteLine("1. transfer money");
        Console.WriteLine("2. withdraw money");
        Console.WriteLine("3. deposit money");
        Console.WriteLine("4. view account balance");
        var userOption = Console.ReadLine();

        while (true)
        {
            string userContinue;
                    if (userOption=="1" || userOption=="2")
                {
                    account.RemoveMoney();
                    Console.Write($"do you want to go back to the main menu ? YES/NO   ");
                    userContinue=Console.ReadLine();

                                if (userContinue.ToLower() == "yes")
                            {
                               DisplayMenu(account.name);     
                            }

                }
                if (userOption=="3")
                {
                    // BankAccount addMoney = new BankAccount();
                    // addMoney.AddMoney(addMoney.balance);
                    account.AddMoney();
                     userContinue=Console.ReadLine();

                                if (userContinue.ToLower() == "yes")
                            {
                               DisplayMenu(account.name);     
                            }

                }
                if (userOption=="4")
                {
                    account.CheckBalance();
                         userContinue=Console.ReadLine();

                                if (userContinue.ToLower() == "yes")
                            {
                               DisplayMenu(account.name);     
                            }
                }
        }
    }
}