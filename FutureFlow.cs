using System;

using System.Linq;

using System.Collections.Generic;
using System.Threading;



namespace TodoList;



public class TodoListApp
{
    static List<string> Tasks = new List<string>();


    public static void Main()
    {
        bool isRunning = true;
        Console.WriteLine($"welcome to FutureFlow ..the first AI powered todo list app that only runs on the console ");
        Thread.Sleep(300);
        Console.WriteLine($"you can choose to doubt us if you want ,  you wont be judged ..");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        while (isRunning == true)
        {
            Console.WriteLine($"choose the option you wamt to perfom");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. remove completed or inactive tasks");
            Console.WriteLine("4. exit");

            int userInput = int.Parse(Console.ReadLine());

            //the  conditional logic

            if (userInput == 1)
            {
                AddTask();
            }

            else if (userInput == 2)
            {
                ViewTasks();
            }








        }








    }

    static void AddTask()
    {
        Console.WriteLine($"input the task you want to add");
        string taskToAdd = Console.ReadLine();

        Tasks.Add(taskToAdd);

        Thread.Sleep(500);
        Console.WriteLine($"task added to FutureFlow.....");
        Thread.Sleep(500);



    }


    static void ViewTasks()
    {
        Console.WriteLine($"below are your tasks . make sure you stick with them .  procrastination is a killer");

        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"your {i + 1} task is {Tasks[i]}");
        }
    }

}

