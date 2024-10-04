public class Car
{
    public string brand;
    public int year;

    public Car(string brand, int year)
    {
        this.brand = brand;
        this.year = year;
    }

    public Car(Car other)
    {
        this.brand = other.brand;
        this.year = other.year;
    }

    public void Display()
    {
        Console.WriteLine($"Brand: {brand}, Year: {year}");
    }
}
