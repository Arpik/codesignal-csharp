public class Item
{
    private string name;
    private double price; // private price field

    // Price property with a condition to enforce a minimum price of 20.00
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 20.00)
            {
                price = 20.00; // enforce minimum price
            }
            else
            {
                price = value;
            }
        }
    }

    // Constructor accepting a name and a price
    public Item(string name, double price)
    {
        this.name = name;
        this.Price = price; // Use the Price property to enforce the minimum price condition
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

// public class Program
// {
//     public static void Main()
//     {
//         Item item = new Item("Tablet", 150.00); // Initialize with a valid price
//         item.Name = "Laptop"; // Change name
//         item.Price = 19.99; // Try setting the price below 20.00

//         Console.WriteLine($"Name: {item.Name}");
//         Console.WriteLine($"Price: {item.Price}"); // Print the price to confirm it is set to 20.00
//     }
// }