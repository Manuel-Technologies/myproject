using System;

using System.Linq;
using System.IO;
using System.IO;

using System.Collections.Generic;
using System.Threading;



namespace TaskFlow;



public class TodoListApp
{
    static List<string> Tasks = new List<string>();
    static string filePath = "tasks.txt";


    public static void Main()
    {
        bool isRunning = true;
        Console.WriteLine($"welcome to FutureFlow ..the first AI powered todo list app that only runs on the console ");
        Thread.Sleep(300);
        Console.WriteLine($"you can choose to doubt us if you want ,  you wont be judged ..");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

        LoadTasksFromFile(filePath);

        while (isRunning == true)
        {
            Console.WriteLine($"choose the option you wamt to perfom");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. remove completed or inactive tasks");
            Console.WriteLine("4. Edit or update task");
            Console.WriteLine("5. exit");
            Console.WriteLine("");


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

            else if (userInput == 3)
            {
                DeleteTask();
            }

            else if (userInput == 4)
            {
                UpdateTask();
            }

            else if (userInput == 5)
            {
                isRunning = false;
            }

            else
            {
                Console.WriteLine($"choose a valid option");
                Console.WriteLine("");
            }








        }








    }

    //FOR ADDING OF TASK
    static void AddTask()
    {
        Console.WriteLine($"input the task you want to add");
        Console.WriteLine("");
        string taskToAdd = Console.ReadLine();
        Console.WriteLine("");

        Tasks.Add(taskToAdd);

        Thread.Sleep(500);
        Console.WriteLine($"task added to FutureFlow.....");
        Thread.Sleep(500);
        Console.WriteLine("");

        //ask if the user still wants to add another task
        Console.WriteLine($"do you still want to add another task ?  yes/no ?");
        string secondChoice = Console.ReadLine();

        if (secondChoice == "yes")
        {
            AddTask();
        }

        SaveTasksToFile(filePath, Tasks);






    }

    //FOR VIEWING TASK
    static void ViewTasks()
    {
        Console.WriteLine($"below are your tasks . make sure you stick with them .  procrastination is a killer");
        Console.WriteLine("");
        Console.WriteLine("----------------------------");
        Console.WriteLine("");

        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"Task {i + 1}  is {Tasks[i]}");
            Console.WriteLine("");
        }

        Console.WriteLine("-----------------------");
        Console.WriteLine("");
    }

    //FOR DELETING TASK
    static void DeleteTask()
    {
        Console.Write($"what is the number of the task you want to delete ?  :   ");
        Console.WriteLine("");
        Console.WriteLine("");
        ViewTasks();
        int taskToDelete;
        taskToDelete = int.Parse(Console.ReadLine());

        Tasks.Remove(Tasks[taskToDelete - 1]);
        Thread.Sleep(500);
        Console.WriteLine("task deleted.... flow with your future on FutureFlow");
        SaveTasksToFile(filePath, Tasks);

    }

    //FOR UPDATING TASK 

    static void UpdateTask()
    {
        ViewTasks();
        Console.WriteLine("");
        Console.Write($"input the number of the task you want to edit  :  ");
        int taskToBeEdited = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        //   Tasks.Update(Tasks[taskToBeEdited - 1]);

        Console.WriteLine($"write in your new task  :   ");
        string newTask = Console.ReadLine();

        Tasks[taskToBeEdited - 1] = newTask;

        SaveTasksToFile(filePath, Tasks);
    }


    //FOR SAVING THE TASKS TO A FILE
    static void SaveTasksToFile(string filePath, List<string> Tasks)
    {
        //string filePath = "tasks.txt";
        File.WriteAllLines(filePath, Tasks);
    }


    //FOR LOADING THE TASKS FROM THE FILE

    static void LoadTasksFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.ReadAllLines(filePath);
            //Console.WriteLine(fileContent);

            Tasks.Clear();
            string[] tasksFromFile = File.ReadAllLines(filePath);

            foreach (string task in tasksFromFile)
            {
                Tasks.Add(task);
            }
        }
    }

}



