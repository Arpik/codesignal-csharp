public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

// Add the Triangle class that inherits from Shape
public class Triangle : Shape
{
    // Add a property named 'Side'
    public int Side { get; set; }
    
    public Triangle(int side)
    {
        this.Side = side;
    }

    // Override the Area and Perimeter methods
    public override double Area()
    {
        return (Math.Sqrt(3) / 4) * Side * Side;
    }
    
    public override double Perimeter()
    {
        return 3 * Side;
    }
}

public class Program
{
    static void Main()
    {
        Circle circle = new Circle(3);
        Rectangle rectangle = new Rectangle(4, 6);
        
        // Instantiate Triangle class with side length 3
        Triangle triangle = new Triangle(7);
        
        Console.WriteLine($"Circle Area: {circle.Area()}, Perimeter: {circle.Perimeter()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}, Perimeter: {rectangle.Perimeter()}");
        
        // TODO: Print Triangle area and perimeter
        Console.WriteLine($"Triangle Area: {triangle.Area()}, Perimeter: {triangle.Perimeter()}");
    }
}