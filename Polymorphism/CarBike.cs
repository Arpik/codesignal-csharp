public class Vehicle
{
    public string Model { get; }
    public int Year { get; }

    public Vehicle(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public virtual void Details()
    {
        Console.WriteLine($"Model: {Model}, Year: {Year}");
    }
}

// Define the derived class Car that extends Vehicle
public class Car : Vehicle
{
    // The Car class should have an extra field Seats
    public int Seats { get; set; }
    
    // Add a constructor that initializes the model, year, and seats fields
    public Car(string model, int year, int seats) : base(model, year)
    {
        this.Seats = seats;
    }

    // Override the Details() method to print the seats in addition to the model and year
    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Seats: {Seats}");
    }

}


// Define the derived class Bike that extends Vehicle
public class Bike : Vehicle
{
    // The Bike class should have an extra field Type
    public string Type { get; set; }
    
    // Add a constructor that initializes the model, year, and type fields
    public Bike(string model, int year, string type) : base (model, year)
    {
        this.Type = type;
    }

    // Override the Details() method to print the type in addition to the model and year
    public override void Details()
    {
        base.Details();
        Console.WriteLine($"Type is: {Type}");
    }
}

public class Solution
{
    static void Main()
    {
        // Create an instance of the Car using a base pointer with the model "Toyota Camry", year 2020, and 5 seats
        Car car = new Car("Toyota Camry", 2020, 5);

        // Create an instance of a Bike using a base pointer with the model "Yamaha", year 2018, and type "Sport"
        Bike bike = new Bike("Yamaha", 2018, "Sport");

        // Call the Details() method for each instance
        car.Details();
        bike.Details();
    }
}