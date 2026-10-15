using System;

// This covers type conversion 

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 23;
            double num = 2;


            // implicit type conversion happens automatically. Such as when the variable of a final answer is an int but the operands are 
            // of a different tyep, say doubles. The final answer will assume the type of the variable holding the final answer.
            double newNum = price / num;
            Console.WriteLine($"New Number = {newNum}");

            // explicit type casting needs a cast for it to happen.
            int newNumTwo = price / (int)num;
            Console.WriteLine($"New Number = {newNumTwo}");

            // using int.TryParse returns false if the conversion failed, unlike just using Parse.
            // Using Parse only stops the program from running once it encounters an error, instead of catching it.
            string valueString = "123";
            //int value;

            if(int.TryParse(valueString, out int value))
            {
                Console.WriteLine($"The actual value is {value}.");
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }


        }
    }
}