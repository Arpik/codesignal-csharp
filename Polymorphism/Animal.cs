public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Define the Bird class as a derived class of Animal
// Add a method Fly() that prints "The bird is flying"
// Override the MakeSound() method to print "Chirp"
public class Bird : Animal
{   
    public void Fly()
    {
        Console.WriteLine("The bird is flying");    
    }

    public override void MakeSound()
    {
        Console.WriteLine("Chirp");
    }
}

public class Solution
{
    static void Main()
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        
        // Create a Bird object
        Bird myBird = new Bird();
        
        myDog.MakeSound(); // Outputs: Woof
        myCat.MakeSound(); // Outputs: Meow
        
        // Call the MakeSound method from the Bird object
        myBird.MakeSound();
        
        // Call the Fly method from the Bird object
        myBird.Fly();
    }
}