using System;
using System.Collections.Generic;

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
        static void AddTask(List<string> tasks, List<bool> done)
        {
            Console.Write("Enter task: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Task cannot be empty.");
                return;
            }

            tasks.Add(input.Trim());
            done.Add(false);

            Console.WriteLine($"Added: {input.Trim()}");
        }

        // the view tasks function came here
        static void ViewTasks(List<string> tasks, List<bool> done)
        {
            if(tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            Console.WriteLine("Your Tasks: ");
            for(int i = 0; i < tasks.Count; i++)
            {
                string mark = done[i] ? "[x]" : "[ ]";
                Console.WriteLine($"{i + 1}. {mark} {tasks[i]}");
            }
        }

        // the function for marking tasks as done is down below
        static void MarkTask(List<string> tasks, List<bool> done)
        {
            int choice;

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            ViewTasks(tasks, done);

            choice = ValidateInput("Choose task number to mark: ", 1, tasks.Count);

            if (done[choice - 1] == true)
            {
                Console.WriteLine("Task already marked as done.");
                return;
            }

            done[choice - 1] = true;
            Console.WriteLine("Task marked as done successfully.");

        }

        // to remove a task, this function was used 
        static void RemoveTask(List<string> tasks, List<bool> done)
        {
            int choice;

            if(tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            ViewTasks(tasks, done);

            choice = ValidateInput("Enter task number to remove: ", 1, tasks.Count);

            tasks.RemoveAt(choice - 1);
            done.RemoveAt(choice - 1);

            Console.WriteLine("Task removed successfully.");

        }

        static void Main(string[] args)
        {

            List<string> tasks = new();
            List<bool> done = new();


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
                        AddTask(tasks, done);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        // view tasks function 
                        ViewTasks(tasks, done);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        // mark task function 
                        MarkTask(tasks, done);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        // remove task function 
                        RemoveTask(tasks, done);

                        Console.Write("Press any key to continue ");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 5:
                        Console.WriteLine("Exiting...");

                        return;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}