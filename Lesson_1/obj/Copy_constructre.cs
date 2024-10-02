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

class Program
{
    static void Main()
    {
        Car car = new Car("Tesla", 2021);
        car.Display();

        Car carCopy = new Car(car);
        carCopy.Display();
    }
}