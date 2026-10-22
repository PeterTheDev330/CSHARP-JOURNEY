using System;
using System.Collections.Generic;

// this is my initial to - do list try out
// this only has three functions; add, remove, and view

namespace ToDoList
{
    class Program
    {
        
        static int ValidateInput(string prompt, int lower, int upper)
        {

            int input;

            Console.Write(prompt);

            while(!int.TryParse(Console.ReadLine(), out input) || input < lower || input > upper)
            {
                Console.WriteLine($"Enter whole number between {lower} and {upper}");
                Console.Write("Try Again: ");
            }

            return input;
        }

        static int Menu()
        {
            int choice;

            Console.WriteLine("1. View List \n2. Add Item \n3. Remove Item \n4. Quit");

            choice = ValidateInput("Enter option: ", 1, 4);

            return choice;
        }

        // the add item function 
        static void AddTask(List<string> tasks, string task)
        {
            tasks.Add(task);

            Console.WriteLine("Task added successfully");
        }

        // remove task function 
        static void RemoveTask(List<string> tasks, int taskAt)
        {
            tasks.RemoveAt(taskAt - 1);

            Console.WriteLine("Task removed successfully");
        }

        // view tasks function 
        static void ViewTasks(List<string> tasks)
        {
            for(int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }

        static void Main(string[] args)
        {


            List<string> tasks = new List<string>();
            string task;
            int taskAt;

            while (true)
            {
                Console.WriteLine("==================================================================");
                Console.WriteLine("\t\t MY TO - DO LIST ");
                Console.WriteLine("==================================================================");

                int choice = Menu();

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        // view list function 
                        ViewTasks(tasks);

                        Console.Write("\nPress any key to proceed ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        // add item function 
                        Console.Write("Task: ");
                        task = Console.ReadLine();
                        AddTask(tasks, task);

                        Console.Write("\nPress any key to proceed ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 3:
                        // remove item function 
                        Console.Write("Remove task number: ");
                        taskAt = Convert.ToInt32(Console.ReadLine());
                        RemoveTask(tasks, taskAt);

                        Console.Write("\nPress any key to proceed ");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                        break;

                    default:
                        Console.WriteLine("Unknown Conrol");
                        break;
                }
            }

        }
    }
}