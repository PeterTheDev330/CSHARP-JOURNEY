using System;

class Person
{
    public string Name = "";
    public int Age;

    //private int _age;

    //public int Age
    //{
    //    get => _age;
    //    set
    //    {
    //        if(value < 0 || value > 150)
    //        {
    //            throw new ArgumentException(nameof(value), "Age must be 0 to 150.");
    //        }
    //        _age = value;
    //    }
    //}

    public Person(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        }
        if(age < 0 || age > 150)
        {
            throw new ArgumentException("Age must be 0 to 150");
        }

        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}, and I am {Age} years old.");
    }
}