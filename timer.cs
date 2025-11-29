using System;
using System.Linq;
using System.Threading;

namespace HelloWorld;

public class countDownTimer
{
    public static void Main()
    {

        int timeInSeconds;

        Console.WriteLine("input the time in seconds");

        timeInSeconds = int.Parse(Console.ReadLine());

        for (int x = timeInSeconds; x >= 0; x--)
        {

            int hours = x / 3600;
            int minutes = (x / 60) % 60;
            int seconds = x % 60;

            // Console.WriteLine($"{hours} : {minutes} : {seconds}");

            //  Console.Write("\r" + (hours) + ":" + (minutes) + ":" + (seconds));

            //  Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
            Thread.Sleep(1000);

        }



        Console.WriteLine("time's up");
    }



}

