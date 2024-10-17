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
    // Add a University property of type string
    public string University { get; set; }

    // Constructor to include the university of the student
    public Student(string name, int age, string major, string university) : base(name, age)
    {
        this.Major = major;
        this.University = university;
    }

    // DisplayStudent method which includes the university of the student as well
    public void DisplayStudent()
    {
        base.Display();
        Console.WriteLine($"Major: {Major}");
        Console.WriteLine($"University: {University}");
    }

}

public class Program
{
    static void Main()
    {
        // constructor call which includes the university of the student "TU Delft"
        Student student = new Student("Bob", 25, "Computer Science", "TU Delft");
        student.DisplayStudent();
    }
}