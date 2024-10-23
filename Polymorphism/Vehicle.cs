public class Vehicle
{
  public virtual void StartEngine()
    {
        Console.WriteLine("Engine has started");
    }

    // Add the HonkHorn() virtual method here. It should print "Honk! Honk!"
    public virtual void HonkHorn()
    {
        Console.WriteLine("Honk! Honk!");
    }
}

public class Car : Vehicle
{
    // Override the HonkHorn() method here. It should print "Beep! Beep!"
    public override void HonkHorn()
    {
        Console.WriteLine("Beep! Beep!");
    }
}

public class Truck : Vehicle
{
    // No need to override the HonkHorn method
}

public class Solution
{
     static void Main()
    {
        Vehicle myCar = new Car();
        Vehicle myTruck = new Truck();

        // Call the HonkHorn() method for the Car object
        myCar.HonkHorn();
        
        // Call the HonkHorn() method for the Truck object
        myTruck.HonkHorn();
    }
}