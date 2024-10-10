public class Person_Auto
{
    // TODO: Replace the private field 'name' with a public auto-implemented property
    public string Name { get; set; }

    // Replace the private field 'age' with a public auto-implemented property
    public int Age { get; set; }

    // Modify the constructor to directly set the auto-implemented properties
    public Person_Auto(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// public class Program
// {
//     static void Main()
//     {
//         Person person = new Person("Alice", 30);
//         person.Name = "Bob";
//         person.Age = 25;

//         Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//     }
// }