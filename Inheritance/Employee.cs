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

public class Employee : Person
{
    // Add a property named EmpID of type string
    public string EmpID { get; set; }
    // Modify the constructor to also take an empID of type string and initialize it
    public Employee(string name, int age, string empID) : base(name, age)
    {
        this.EmpID = empID;
    }

    public void DisplayEmployee()
    {
        base.Display();
        // Display Employee ID in addition to Name and Age
        Console.WriteLine($"EmpID: {EmpID}");
    }
}

public class Program
{
    static void Main()
    {
        // TODO: Modify the constructor call to also pass an empID of "E12345"
        Employee employee = new Employee("Alice", 30, "E12345");
        employee.DisplayEmployee();
    }
}