public class Person
{
    // Change 'name' and 'age' to private fields
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Create properties to get and set 'name' and 'age'
    public string Name
    {
        get { return name; }
        set { name = value; }   
    }
    
    public int Age
    {
        get {return age; }
        set {age = value; }
    }

}

// public class Program
// {
//     static void Main()
//     {
//         Person person = new Person("Alice", 30);

//         // Modify 'name' and 'age' using the properties
//         person.Name = "Bob";
//         person.Age = 25;

//         // Retrieve 'name' and 'age' using the properties
//         Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
//     }
// }