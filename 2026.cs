using System;
using System.Threading;

class Program
{
    static void Main()
    {
        DateTime targetTime = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Local);

        // Console.CursorVisible = false;

        while (true)
        {
            TimeSpan remaining = targetTime - DateTime.Now;

            if (remaining <= TimeSpan.Zero)
            {
                TriggerAlarm();
                break;
            }

            Console.Clear();
            Console.WriteLine("🎉 New Year Countdown 🎉");
            Console.WriteLine();
            Console.WriteLine(
                $"{remaining.Days:D2} days " +
                $"{remaining.Hours:D2} hours " +
                $"{remaining.Minutes:D2} minutes " +
                $"{remaining.Seconds:D2} seconds"
            );

            Thread.Sleep(1000);
        }
    }

    static void TriggerAlarm()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("🎆 HAPPY NEW YEAR 2026 🎆");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            Console.Beep(1000, 500);
            Thread.Sleep(200);
        }

        Console.ResetColor();
        // Console.CursorVisible = true;
    }
}
