// Define an abstract class Appliance with abstract methods TurnOn and TurnOff
public abstract class Appliance
{
    public abstract void TurnOn();
    public abstract void TurnOff();
}

// Define a class Television that inherits from Appliance and implements TurnOn and TurnOff
    // - The TurnOn method should print "The television is now ON."
    // - The TurnOff method should print "The television is now OFF."
    
public class Television : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine($"The television is now ON.");
    }
    
    public override void TurnOff()
    {
        Console.WriteLine($"The television is now OFF");
    }
}

// Define a class WashingMachine that inherits from Appliance and implements TurnOn and TurnOff
    // - The TurnOn method should print "The washing machine is now ON."
    // - The TurnOff method should print "The washing machine is now OFF."

public class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine($"The washing machine is now ON.");
    }
    
    public override void TurnOff()
    {
        Console.WriteLine($"The washing machine is now OFF.");
    }
}

class Program
{
    static void Main()
    {
        // Create an object of type Appliance, instantiated as Television, and call its methods
        Appliance appliance = new Television();
        appliance.TurnOn();
        appliance.TurnOff();

        // Create an object of type Appliance, instantiated as WashingMachine, and call its methods
        Appliance appliance1 = new WashingMachine();
        appliance1.TurnOn();
        appliance1.TurnOff();
    }
}