using System;
using System.Drawing;

namespace PracticeTwo
{
    class Program
    {
        static void Main(string[] name)
        {

            Rectangle shapeOne = new Rectangle(10, 5);

            double AreaAnswer = shapeOne.Area();
            double ParameterAnswer = shapeOne.Parameter();

            Console.WriteLine($"Area = {AreaAnswer} \nParameter = {ParameterAnswer}");

        }
    }
}