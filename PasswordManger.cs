using System;
using System.Linq;

using System.Collections.Generic;
using sum;
namespace sum;

public class PasswordManager
{
    static List<PasswordEntry> passwordDetails = new List<PasswordEntry>();


    public static void Main()
    {
        string userChoice;
        Console.WriteLine("welcome to your password manager");
        Console.WriteLine();

        Console.WriteLine("what do you want to do ? ");
        Console.WriteLine("1. view passwords");
        Console.WriteLine("2. add passwords");
        Console.WriteLine("3. delete passwords");
        Console.WriteLine("4. update password");
        Console.WriteLine("5. exit the app");

        userChoice = Console.ReadLine();

        //using conditionals to determine the next action

        if (userChoice == "1")
        {
            ViewPassword();
        }

        else if (userChoice == "2")
        {
            AddPasswordDetails();
        }

    }

    public static void AddPasswordDetails()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("input the password you want to store ");
            string passwordToStore = Console.ReadLine();
            Console.WriteLine("input the name of the account you want to store it to ");
            string accountName = Console.ReadLine();
            PasswordEntry entry = new PasswordEntry();
            entry.AccountName = accountName;
            entry.Password = passwordToStore;
            passwordDetails.Add(entry);
            Console.WriteLine("password stored successfully");
            Console.WriteLine();

            Console.WriteLine("do you still want to store another password  ?  yes/no");
            string loopDeterminant = Console.ReadLine();

            if (loopDeterminant == "no")
            {
                //isRunning = false;
                Main();
            }

            else if (loopDeterminant == "yes")
            {
                AddPasswordDetails();
            }

            else
            {
                Console.WriteLine("input a valid option");
                for (int i = 0; i < passwordDetails.Count; i++)
                {
                    Console.WriteLine($" {i + 1} account : {entry.AccountName}");
                }
            }
        }

    }

    public static void ViewPassword()
    {
        Console.WriteLine("this are your saved passwords");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < passwordDetails.Count; i++)
        {
            //Console.WriteLine($"your {i + 1} password is {passwordDetails[i]}");

            PasswordEntry entry = passwordDetails[i];

            Console.WriteLine($"Account : {entry.AccountName}");
            Console.WriteLine($"Password : {entry.Password}");
            Console.WriteLine("");

        }
        Console.WriteLine("_____________________");


        string userChoice;
        //  Console.WriteLine("welcome to your password manager");
        Console.WriteLine();

        Console.WriteLine("what do you want to do ? ");
        Console.WriteLine("1. view passwords");
        Console.WriteLine("2. add passwords");
        Console.WriteLine("3. delete passwords");
        Console.WriteLine("4. update password");
        Console.WriteLine("5. exit the app");

        userChoice = Console.ReadLine();

        //using conditionals to determine the next action

        if (userChoice == "1")
        {
            ViewPassword();
        }

        else if (userChoice == "2")
        {
            AddPasswordDetails();
        }
    }

    public static void UpdatePasswordDetails()
    {
        Console.WriteLine("choose the account ID that you want to change ");

    }




}

public class PasswordEntry
{
    public string AccountName { get; set; }
    public string Password { get; set; }



}


