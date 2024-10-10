public class Vehicle
{
    private string brand;
    private int year;

    public Vehicle(string brand, int year)
    {
        this.brand = brand;
        this.year = year;
    }

    // Define the Brand property with getter and setter
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    
    // Define the Year property with getter and setter
    public int Year
    {
        get { return year; }
        set { year = value; }
    
    }
}   


// public class Program
// {
//     static void Main()
//     {
//         Vehicle vehicle = new Vehicle("Toyota", 2015);

//         // Use the Brand property to change the vehicle's brand to "Honda"
//         vehicle.Brand = "Honda";
        
//         // Use the Year property to change the vehicle's year to 2020
//         vehicle.Year = 2020;
        
//         // Print the brand using the Brand property
//         Console.WriteLine(vehicle.Brand);
        
//         // Print the year using the Year property
//         Console.WriteLine(vehicle.Year);
//     }
// }