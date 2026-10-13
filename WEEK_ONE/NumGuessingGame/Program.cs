using System; 

// This is exercise one. Building a number guessing game using loops, conditionals, and input handling.

namespace NumGuessingGame
{
    class Program
    {

        // This is a validation function to ensure the  number is an integer, and it's either a 1 or a 0
        // This was used when collecting input afte asking if the user wants to play again.
        // Do keep in mind that methods have not been covered yet in the C# lessons.
        static int Validate(int lower, int upper, string prompt)
        {

            while (true)
            {
                Console.Write(prompt);

                string? input = Console.ReadLine();

                if (input == null)
                    throw new EndOfStreamException("Input stream closed.");
                if (int.TryParse(input, out int value) && (value == lower || value == upper))
                    return value;

                Console.WriteLine($"Invalid input. Input must be {lower} or {upper}: ");
            }
        }
        static void Main(string[] args)
        {
            int actualNumber;
            int guessedNumber;
            int replay;

            while (true)
            {

                // Input collection and error check is done here
                Console.Write("Player one, enter the actual number: ");
                //actualNumber = Convert.ToInt32(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out actualNumber))
                {
                    Console.WriteLine("Input not a number.");
                    Console.Write("Try again: ");
                }

                while (true)
                {
                    Console.Write("Player two, guess the number: ");
                    //guessedNumber = Convert.ToInt32(Console.ReadLine());
                    while (!int.TryParse(Console.ReadLine(), out guessedNumber))
                    {
                        Console.WriteLine("Input not a number.");
                        Console.Write("Try again: ");
                    }


                    // Now, the comparison is performed to check the actual and guessed number
                    if (actualNumber == guessedNumber)
                    {
                        Console.WriteLine("That is correct. Yayyy !!!!");
                        break;
                    }
                    else if (actualNumber < guessedNumber)
                    {
                        Console.WriteLine("Oops. That's higher. Try again.");
                        continue;
                    }
                    else if (actualNumber > guessedNumber)
                    {
                        Console.WriteLine("Oops. That's lower. Try again.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Something ain't right.");
                        continue;
                    }
                }


                replay = Validate(0, 1, "Wanna play again (1 for yes, 0 for no): ");

                if (replay == 1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }
        }
    }
}