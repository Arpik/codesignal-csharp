// Create an abstract base class named Vehicle with an abstract method 'Drive'.
public abstract class Vehicle
{
    public abstract void Drive();
}

// Create a class named Car that inherits from Vehicle and implements the 'Drive' method to output "Driving a Car!".
public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving a Car");
    }
}

// Create a class named Bike that inherits from Vehicle and implements the 'Drive' method to output "Riding a Bike!".

public class Bike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Riding a Bike");
    }
}