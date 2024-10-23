// Create the Vehicle class
public class Vehicle
{
    // Define properties Make (string) and Year (int)
    public string Make { get; set; }
    public int Year { get; set; }
    
    // Implement a constructor to initialize Make and Year
    public Vehicle(string make, int year)
    {
        this.Make = make;
        this.Year = year;    
    }
    
    // Implement a Display method to print Make and Year
    public void Display()
    {
        Console.WriteLine($"Make: {Make}, Year: {Year}");
    }    
}

// Create the Car class by inheriting from Vehicle class
public class Car : Vehicle
{
    //Define property Model (string)
    public string Model { get; set; }
    
    // Implement a constructor to initialize Make, Year, and Model using the base class constructor
    public Car(string make, int year, string model) : base(make, year)
    {
        this.Model = model;
    }
    
    // Implement a DisplayCar method to call the base Display method and print Model
    public void DisplayCar()
    {
        base.Display();
        Console.WriteLine($"Model: {Model}");
    }
}

public class Program
{
    static void Main()
    {
        // Create an instance of Car and call DisplayCar to show its details
        
        Car car = new Car("This is a Make", 2015, "Audi");
        car.DisplayCar();
    }
}