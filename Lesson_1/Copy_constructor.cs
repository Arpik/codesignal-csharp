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

public class Film
{
    public string title;
    public string director;

    public Film(string title, string director)
    {
        this.title = title;
        this.director = director;
    }

    // TODO: Define the copy constructor that initializes the object with the same data as the other object
    public Film(Film other)
    {
        this.title = other.title;
        this.director = other.director;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {title}, Director: {director}");
    }
}

class Program
{
    static void Main()
    {
        Film film = new Film("Inception", "Christopher Nolan");
        film.Display();

        // TODO: Create a copy of the film object named filmCopy using the copy constructor and display its data
        Film filmCopy = new Film(film);
        filmCopy.Display();
    }
}