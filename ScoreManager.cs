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
        Console.WriteLine("below are your subjects and scores");
        Console.WriteLine($"");

        for (int i = 0; i < subjects.Count; i++)
        {
            Console.WriteLine(subjects[i] + ":" + scores[i]);
        }


        Console.WriteLine("");
        var highestScore = scores.Max();
        var lowestScore = scores.Min();
        var average = scores.Average();

        Console.WriteLine("");
        Console.WriteLine($"your highest score is {highestScore}");
        Console.WriteLine($"your lowest score is {lowestScore}");
        Console.WriteLine($"your average is {average}");





    }


}

