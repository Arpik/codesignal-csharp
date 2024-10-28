public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
    
    // Add an abstract method 'Description'
    public abstract string Description();
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

    // Implement the Description method for Circle
    public override string Description()
    {
        // return "This is a circle.";
        return "This is a circle.";        
    }
}