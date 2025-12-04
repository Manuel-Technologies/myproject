using System;

using System.Linq;

using System.Collections.Generic;
using System.Threading;
using System.Data;



namespace BankingApp;



public class BankDemo
{

    static double balance = 0;
    public static void Main()
    {
        // double balance = 0;
        bool isRunning = true;
        Console.WriteLine("Welcome to SwiftPay..");
        Thread.Sleep(500);

        Console.WriteLine("the first real console bank");
        Thread.Sleep(500);

        while (isRunning == true)
        {


            Console.WriteLine($"choose an option to continue with");
            Thread.Sleep(500);
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

            else if (userOption == 2)
            {
                balance += DepositMoney();


            }

            else if (userOption == 3)
            {
                balance -= Withdraw();

            }

            else if (userOption == 4)
            {
                isRunning = false;
                Thread.Sleep(500);
                Console.WriteLine("thank you for banking with us");
            }

            else if (userOption < 1 || userOption > 4)
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

        // depositAmount = balance += depositAmount;
        if (depositAmount <= 0)
        {
            Console.WriteLine("the deposit amount must be greater than 0");
            return 0;

        }

        else
        {
            Console.WriteLine($"the deposit of ₦{depositAmount} is successful");
        }
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

        else if (withdrawAmount < 0)
        {
            Console.WriteLine("withdraw amount must be greater than 0");
            return 0;
        }

        else
        {
            Console.WriteLine($"withdrawal of ₦{withdrawAmount} is successful...");
        }


        return withdrawAmount;

    }

}

