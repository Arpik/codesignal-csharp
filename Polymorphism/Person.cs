public class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    public virtual void Display() 
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person 
{
    public string Major { get; set; }
    
    public Student(string name, int age, string major) : base(name, age) 
    {
        Major = major;
    }

    public override void Display() 
    {
        base.Display();
        Console.WriteLine($"Major: {Major}");
    }
}

public class Teacher : Person 
{
    public string Subject { get; set; }
    
    public Teacher(string name, int age, string subject) : base(name, age) 
    {
        Subject = subject;
    }

    public override void Display() 
    {
        base.Display();
        Console.WriteLine($"Subject: {Subject}");
    }
}

public class Solution 
{
    public static void Main(string[] args) 
    {
        List<Person> people = new List<Person> 
        {
            new Person("Alice", 30),
            new Student("Bob", 20, "Computer Science"),
            new Teacher("Charlie", 40, "Math")
        };

        foreach (Person person in people) 
        {
            person.Display();
        }
    }
}