// Define a class Device class
public class Device
{
    // Protected properties: Name (string), PowerStatus (bool)
    protected string Name { get; set; }
    protected bool PowerStatus;
    
    // A constructor to initialize the device name and power status
    public Device(string name, bool powerStatus)
    {
        this.Name = name;
        this.PowerStatus = powerStatus;
    }
    
    // A virtual method 'GetStatus' to print the device name and power status
    public virtual void GetStatus()
    {
        Console.WriteLine($"Device Name: {Name}, Power Status: {PowerStatus}");
    }
}

// Define a class Laptop derived from Device with the following:
public class Laptop : Device
{
    // A private property: OperatingSystem (string)
    private string OperatingSystem { get; set; }
    
    // A constructor to initialize the name, power status, and operating system
    public Laptop(string name, bool powerStatus, string operatingSystem) : base(name, powerStatus)
    {
        this.OperatingSystem = operatingSystem;
    }

    // An overridden 'GetStatus' method that prints device info and the operating system in addition to the base    class info
    public override void GetStatus()
    {
        base.GetStatus();
        Console.WriteLine($"Operating System: {OperatingSystem}");
    }
}

// Define a class Smartphone derived from Device with the following:
public class Smartphone : Device
{
    // A private property: Carrier (string)
    private string Carrier { get; set; }
    
    // A constructor to initialize the name, power status, and carrier
    public Smartphone(string name, bool powerStatus, string carrier) : base(name, powerStatus)
    {
        this.Carrier = carrier;
    }

    // An overridden 'GetStatus' method that prints device info and the carrier in addition to the base class info
    public override void GetStatus()
    {
        base.GetStatus();
        Console.WriteLine($"Carrier is: {Carrier}");
    }

}


public class Solution
{
    static void Main()
    {
        // Create an instance of Laptop with the name "MacBook Pro", power status true, and OS "macOS"
        Laptop laptop = new Laptop("MacBook Pro", true, "macOS");
        
        // Create an instance of Smartphone with the name "iPhone", power status false, and carrier "Verizon"
        Smartphone smartphone = new Smartphone("iPhone", false, "Verizon");
         
        // Call the 'GetStatus' method of both classes to display their details
        laptop.GetStatus();
        smartphone.GetStatus();
    }
}