public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student : Person
{
    public string Major { get; set; }

    public Student(string name, int age, string major) : base(name, age)
    {
        this.Major = major;
    }

    public void DisplayStudent()
    {
        base.Display();
        Console.WriteLine($"Major: {Major}");
    }
}

// Add the GraduateStudent class

public class GraduateStudent : Student
{
    // Add a property ThesisTitle of type string
    public string ThesisTitle { get; set; }
    
    // Implement the constructor to initialize name, age, major, and thesisTitle
    
    public GraduateStudent(string name, int age, string major, string thesisTitle): base(name, age, major)
    {
        this.ThesisTitle = thesisTitle;
    }
        
// Add a method DisplayGraduateStudent to display name, age, major, and thesisTitle

    public void DisplayGraduateStudent()
    {
        base.DisplayStudent();
        Console.WriteLine($"Thesis Title: {ThesisTitle}");
    }
}


public class Program
{
    static void Main()
    {
        // Create an instance of GraduateStudent with the following details
        // Name: "Alice"
        // Age: 28
        // Major: "Biology"
        // ThesisTitle: "The Effect of Sunlight on Plant Growth"
        
        GraduateStudent graduatestudent = new GraduateStudent("Alice", 28, "Biology", "The Effect of Sunlight on Plant Growth");
        
        // Call the DisplayGraduateStudent method on the instance of GraduateStudent
        graduatestudent.DisplayGraduateStudent();
    }
}