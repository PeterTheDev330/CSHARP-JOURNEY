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

        static int Menu()
        {
            int choice;

            Console.WriteLine("1. Deposit \n2. Withdraw \n3. Show balance \n4. Show statement \n5. Quit");

            choice = ValidateInput("Enter choice: ", 1, 5);

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

            //var account = new BankAccount("Peter", 1000m);
            //account.Deposit(50m);
            //var transact = new Transaction(TransactionType.Deposit, 50m, 1050m);

            //Console.WriteLine(account);
            //Console.WriteLine(transact);


            List<BankAccount> accounts = new();


            int menuChoice;
            decimal amount;

            int firstChoice;

            Console.WriteLine("1. Create Account \n2. Exit");
            firstChoice = ValidateInput("Enter choice: ", 1, 2);
            switch (firstChoice)
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
                                break;
                            case 2:
                                amount = ValidateInput("Enter withdraw amount: ", 1m, account.Balance);
                                account.Withdraw(amount);
                                break;
                            case 3:
                                Console.WriteLine(account);
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
                                break;
                            case 5:
                                Console.WriteLine("Exiting...");
                                break;
                            default:
                                // default option comes here
                                break;
                        }
                    }
                    break;
            }
        }



    }
}