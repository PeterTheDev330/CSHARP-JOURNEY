using System;

// this is a class; or a blueprint 
class Person
{
    public string Name { get; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        }
        if(age < 0 || age > 150)
        {
            Console.WriteLine("Age must be between 1 and 150.");
        }
        Name = name;
        Age = age;
    }

    // overloading constructors
    //public Person(string name) : this(name, 0) { }

    public override string ToString() => $"{Name} ({Age})";

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }

    public void HaveBirthday()
    {
        Age++;
    }
}
