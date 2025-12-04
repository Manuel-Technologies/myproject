using System;

using System.Linq;

using System.Collections.Generic;
using System.Threading;



namespace BankingApp;



public class BankDemo
{

    static double balance = 0;
    public static void Main()
    {
        double balance = 0;
        bool isRunning = true;

        while (isRunning == true)
        {
            Console.WriteLine("Welcome to SwiftPay..");
            Thread.Sleep(4000);

            Console.WriteLine("the first real console bank");
            Thread.Sleep(2000);

            Console.WriteLine($"choose an option to continue with");
            Thread.Sleep(2000);
            Console.WriteLine($" 1. check balance");
            Console.WriteLine($" 2. Deposit");
            Console.WriteLine($" 3. withdraw ");
            Console.WriteLine($" 4. exit");

            //take and handle the user option check the user input

            int userOption = int.Parse(Console.ReadLine());

            if (userOption == 1)
            {
                CheckBalance();
            }

            if (userOption == 2)
            {
                DepositMoney();
            }

            if (userOption == 3)
            {
                Withdraw();
            }

            if (userOption == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("choose a valid option");
            }
        }

    }


    public static void CheckBalance()
    {
        Console.WriteLine($"your balance is ₦{balance}");
    }


    public static double DepositMoney()
    {
        double depositAmount;
        Console.WriteLine("input the amount you want to deposit...");
        depositAmount = double.Parse(Console.ReadLine());

        depositAmount = balance = +depositAmount;

        return depositAmount;
    }

    public static double Withdraw()
    {
        Console.WriteLine("how much do you want to withdraw ??");
        double withdrawAmount = double.Parse(Console.ReadLine());

        if (withdrawAmount > balance)
        {
            Console.WriteLine("insufficient funds..pls top up your accpunt");

        }

        if (withdrawAmount < 0)
        {
            Console.WriteLine("withdraw amount must be less than 0");
        }



        return withdrawAmount;

    }

}

