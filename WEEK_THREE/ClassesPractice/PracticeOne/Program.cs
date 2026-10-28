using System;

namespace PracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Person peter = new Person("Peter", 22);
            //peter.Name = "Peter";
            //peter.Age = 22;

            peter.Introduce();

        }
    }
}