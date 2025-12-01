
            using System;

using System.Linq;

using System.Collections.Generic;
using System.Security.Cryptography;



namespace HelloWold;



public static class Program
{
    public static void Main()

    {
        List<string> subjects = new List<string>();
        List<int> scores = new List<int>();

        while (true)
        {
            string userSubject;
            Console.Write($"input the name of the subject or S to stop :   ");
            userSubject = Console.ReadLine();

            if (userSubject.ToLower() == "s") { break; };

            Console.Write($"input the score of the subject  :   ");
            int userScores = int.Parse(Console.ReadLine());

            subjects.Add(userSubject);
            scores.Add(userScores);

        }

        Console.WriteLine("");
        Console.WriteLine("-------------------");
        Console.WriteLine("");
        Console.WriteLine($"");

        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine(subjects[i] + ":" + scores[i]);
        }






    }


}

