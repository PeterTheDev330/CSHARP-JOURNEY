using System;

// this is objects and classes lesson 

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is an object; or an instance of a class
            //Person peter = new Person();
            //peter.Name = "Peter";
            //peter.Age = 22;

            // this is also an object
            //Person niza = new Person();
            //niza.Name = "Niza";
            //niza.Age = 22;

            // an easier way to create objects is using a constructor inside of the class
            Person peter = new Person("Peter", 22);

            Person niza = new Person("Niza", 22);

            //Person simpanzye = new Person();
            //simpanzye.Name = "Simpanzye";
           
            Console.WriteLine($"{peter.Name} is {peter.Age}");
            //Console.WriteLine($"{simpanzye.Name}");

            //var p = new Person { Name = "Cara", Age = 30 };

            // list of objects
            List<Person> people = new()
            {
                new Person("Simpanzye", 22),
                new Person("Ethel", 20)
            };

            people.Add(new Person("Banda", 20));

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }
            

            peter.Introduce();
            peter.HaveBirthday();
            peter.Introduce();

            Console.WriteLine(peter);
        }
    }
}