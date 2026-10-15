using System;

// This is a text based quiz game.

namespace TexQuizGame
{
    class Program
    {

        static bool AskQuestion(string question, string correctAnswer)
        {
            Console.Write($"{question} ");

            string? answer = Console.ReadLine();

            if(answer != null && answer.Trim().ToLower() == correctAnswer.ToLower())
            {
                Console.WriteLine("Correct !!!");
                return true;
            }
            
            Console.WriteLine($"Wrong !!! The answer is {correctAnswer}");
            return false;
            
        }

        static void Main(string[] args)
        {
            int count = 0;

            if (AskQuestion("What is the capital city of Zambia?", "Lusaka")) count++;
            if (AskQuestion("Which province is considered the toursit province?", "Livingstone")) count++;
            if (AskQuestion("Is his excellence Mr. Hakainde Hichilema the president of Zambia for the 2026 - 2031 term?", "Yes")) count++;
            if (AskQuestion("Which lake does Zambia share with Zimbabwe?", "Lake Kariba")) count++;
            if (AskQuestion("Did Zambia get its independence in 1966?", "No")) count++;

            switch (count)
            {
                case 1:
                    Console.WriteLine($"Unsatisfactory. You got {count} / 5 ");
                    break;
                case 2:
                    Console.WriteLine($"Fail. You got {count} / 5 ");
                    break;
                case 3:
                    Console.WriteLine($"Better. You got {count} / 5 ");
                    break;
                case 4:
                    Console.WriteLine($"Good. You got {count} / 5 ");
                    break;
                case 5:
                    Console.WriteLine($"Excellent. You got {count} / 5 ");
                    break;
                default:
                    Console.WriteLine($"Mark unknown. You got {count} / 5 ");
                    break;
            }

        }
    }
}