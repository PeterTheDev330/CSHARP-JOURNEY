using System;
using System.Collections.Generic;
using System.Drawing;


namespace ToDoList
{
    class Program
    {
        // the input validation function came here
        static int ValidateInput(string prompt, int lower, int upper)
        {

            int input;

            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine(), out input) || input < lower || input > upper)
            {
                Console.WriteLine($"Enter whole number between {lower} and {upper}");
                Console.Write("Try Again: ");
            }

            return input;
        }

        // the menu function was written here
        static int Menu()
        {
            int choice;

            Console.WriteLine("1. Add Task \n2. View List \n3. Mark Task \n4. Remove Item \n5. Quit");

            choice = ValidateInput("Enter option: ", 1, 5);

            return choice;
        }

        // the add task function came here
        static void AddTask(List<ToDoItem> tasks)
        {
            Console.Write("Enter task: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Task cannot be empty.");
                return;
            }

            tasks.Add(new ToDoItem(input));

            Console.WriteLine($"Added: {input.Trim()}");
        }

        // the view tasks function came here
        static void ViewTasks(List<ToDoItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            Console.WriteLine("Your Tasks: ");
            for (int i = 0; i < tasks.Count; i++)
            {
                string mark = tasks[i].IsDone ? "[x]" : "[ ]";
                Console.WriteLine($"{i + 1}. {mark} {tasks[i].Title}");
            }
        }

        // the function for marking tasks as done is down below
        static void MarkTask(List<ToDoItem> tasks)
        {
            int choice;

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            ViewTasks(tasks);

            choice = ValidateInput("Choose task number to mark: ", 1, tasks.Count);

            if (tasks[choice - 1].IsDone == true)
            {
                Console.WriteLine("Task already marked as done.");
                return;
            }

            tasks[choice - 1].MarkDone();
            Console.WriteLine("Task marked as done successfully.");

        }

        // to remove a task, this function was used 
        static void RemoveTask(List<ToDoItem> tasks)
        {
            int choice;

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            ViewTasks(tasks);

            choice = ValidateInput("Enter task number to remove: ", 1, tasks.Count);

            tasks.RemoveAt(choice - 1);

            Console.WriteLine("Task removed successfully.");

        }

        static void Main(string[] args)
        {

            List<ToDoItem> tasks = new();


            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine(" \t\t MY TO - DO LIST ");
                Console.WriteLine("================================================");

                int choice = Menu();

                switch (choice)
                {
                    case 1:
                        // add task function 
                        AddTask(tasks);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        // view tasks function 
                        ViewTasks(tasks);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        // mark task function 
                        MarkTask(tasks);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        // remove task function 
                        RemoveTask(tasks);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 5:
                        Console.WriteLine("Exiting...");

                        return;
                        //break;
                    default:
                        break;
                }
            }
        }
    }
}