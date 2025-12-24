using System;

using System.Linq;

using System.Collections.Generic;



namespace sum;
//static List<object> passwordDetails = new List<object>();




public class PasswordManager

//static List<object> passwordDetails = new List<object>();

{
    static List<object> passwordDetails = new List<object>();

    public static void Main()
    {
        Console.WriteLine("welcome to your password manager");
        Console.WriteLine();

        AddPasswordDetails();

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

            passwordDetails.Add(passwordToStore);
            passwordDetails.Add(accountName);

            Console.WriteLine("password stored successfully");
            Console.WriteLine();

            Console.WriteLine("do you still want to store another password  ?  yes/no");
            string loopDeterminant = Console.ReadLine();

            if (loopDeterminant == " no")
            {
                isRunning = false;
            }

            else if (loopDeterminant == "yes")
            {
                AddPasswordDetails();
            }
            
            else{
                Console.WriteLine("input a valid option");
            }
        }

    }

    public static void ViewPassword()
    {
        Console.WriteLine("this are your saved passwords");
        Console.WriteLine("----------------------------------");

        for (int i = 0; i < passwordDetails.Count; i++)
        {
            Console.WriteLine($"your {i + 1} password is {passwordDetails[i]}");

        }
        Console.WriteLine("_____________________");
    }

}

