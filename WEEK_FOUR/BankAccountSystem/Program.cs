using System;
using System.Drawing;
using System.Collections.Generic;
using System.Transactions;

// This is a bank account system 

namespace BankAccountSystem
{
    class Program
    {

        // the input validation function came here
        static int ValidateInput(string prompt, double lower, double upper)
        {

            int input;

            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine(), out input) || input < lower || input > upper)
            {
                Console.WriteLine($"Enter a number between {lower} and {upper}");
                Console.Write("Try Again: ");
            }

            return input;
        }

        // static decimal GetInterest(string prompt, double lower, double upper)
        // {

        //     decimal input;

        //     Console.Write(prompt);

        //     input = Convert.ToDecimal(Console.ReadLine());

        //     while (input < lower || input > upper)
        //     {
        //         Console.WriteLine($"Enter a number between {lower} and {upper}");
        //         Console.Write("Try Again: ");
        //     }

        //     return input;
        // }

        static int Menu()
        {
            int choice;

            Console.WriteLine("1. Deposit \n2. Withdraw \n3. Show balance \n4. Show statement \n5. Quit");

            choice = ValidateInput("Enter choice: ", 1, 5);

            return choice;
        }

        static int SavingsMenu()
        {
            int choice;

            Console.WriteLine("1. Deposit \n2. Add Interest \n3. Withdraw \n4. Show balance \n5. Show statement \n6. Quit");

            choice = ValidateInput("Enter choice: ", 1, 6);

            return choice;
        }

        static string ReadName(string prompt)
        {
            Console.Write(prompt);

            string? input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Account name cannot be empty.");
                Console.Write("Try again: ");
                input = Console.ReadLine();
            }

            return input.Trim();
        }

        static void Main(string[] args)
        {

            List<BankAccount> accounts = new();


            int menuChoice;
            int savingsMenuChoice;
            decimal amount;

            int choice;

            Console.WriteLine("1. Create Account \n2. Exit");
            choice = ValidateInput("Enter choice: ", 1, 2);

            if (choice == 1)
            {
                while (true)
                {
                    Console.WriteLine("1. Ordinary Account \n2. Savings Account \n3, Exit");
                    int accountType = ValidateInput("Choose account type: ", 1, 3);

                    switch (accountType)
                    {
                        case 1:
                            string ownerName = ReadName("Enter account name: ");
                            var account = new BankAccount(ownerName);
                            accounts.Add(account);
                            Console.WriteLine($"Accout #{account.AccountNumber} opened for {ownerName}");

                            while (true)
                            {
                                menuChoice = Menu();

                                switch (menuChoice)
                                {
                                    case 1:
                                        amount = ValidateInput("Enter deposit amount: ", 1, 100000);
                                        account.Deposit(amount);
                                        Console.WriteLine("Deposit successful.");

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;
                                    case 2:
                                        amount = ValidateInput("Enter withdraw amount: ", 1, (double)account.Balance);
                                        account.Withdraw(amount);
                                        Console.WriteLine("Withdraw successful.");

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;
                                    case 3:
                                        Console.WriteLine(account);

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;
                                    case 4:
                                        int number;
                                        Console.Write("Enter number: ");
                                        number = Convert.ToInt32(Console.ReadLine());

                                        var found = accounts.Find(a => a.AccountNumber == number);

                                        if (found == null)
                                        {
                                            Console.WriteLine("Account not found");
                                            break;
                                        }

                                        Console.WriteLine($"Statement found for {found.Owner}");

                                        if (found.Transactions.Count == 0)
                                        {
                                            Console.WriteLine("No transactions yet");
                                        }
                                        else
                                        {
                                            foreach (Transaction t in found.Transactions)
                                            {
                                                Console.WriteLine(t);
                                            }
                                        }

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;
                                    case 5:
                                        Console.WriteLine("Exiting...");
                                        return;
                                        // break;
                                    default:
                                        // default option comes here
                                        break;
                                }
                            }
                            break;

                        case 2:
                            string savingsOwnerName = ReadName("Enter account name: ");
                            // decimal rate = ValidateInput("Enter interest rate (in decimal form): ", 0, 1);
                            Console.Write("Enter interest rate (0 to 1): ");
                            decimal rate = Convert.ToDecimal(Console.ReadLine());

                            var savingsAccounts = new SavingsAccount(savingsOwnerName, rate);
                            accounts.Add(savingsAccounts);
                            Console.WriteLine($"Account #{savingsAccounts.AccountNumber} opened for {savingsOwnerName}");

                            while (true)
                            {
                                savingsMenuChoice = SavingsMenu();

                                switch(savingsMenuChoice)
                                {
                                    case 1:
                                        amount = ValidateInput("Enter deposit amount: ", 1, 100000);
                                        savingsAccounts.Deposit(amount);
                                        Console.WriteLine("Deposit successful.");

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;

                                    case 2:
                                        savingsAccounts.AddInterest();
                                        Console.WriteLine("Interest added successfully.");

                                        break;
                                    
                                    case 3:
                                        amount = ValidateInput("Enter withdraw amount: ", 1, (double)savingsAccounts.Balance);
                                        savingsAccounts.Withdraw(amount);

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;

                                    case 4:
                                        Console.WriteLine(savingsAccounts);

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;

                                    case 5:
                                        int number;
                                        Console.Write("Enter number: ");
                                        number = Convert.ToInt32(Console.ReadLine());

                                        var found = accounts.Find(a => a.AccountNumber == number);

                                        if (found == null)
                                        {
                                            Console.WriteLine("Account not found");
                                            break;
                                        }

                                        Console.WriteLine($"Statement found for {found.Owner}");

                                        if (found.Transactions.Count == 0)
                                        {
                                            Console.WriteLine("No transactions found yet");
                                        }
                                        else
                                        {
                                            foreach(Transaction t in found.Transactions)
                                            {
                                                Console.WriteLine(t);
                                            }
                                        }

                                        Console.Write("Press any key to proceed.");
                                        Console.ReadKey();
                                        Console.Clear();

                                        break;

                                    case 6:
                                        Console.WriteLine("Exiting...");
                                        return;

                                    default:
                                        // default option comes here
                                        break;
                                }

                                // PAUSED HERE
                            }

                            break;
                    }
                }
 
            }
            else
            {
                Console.WriteLine("Exiting...");
            }


        }



    }
}