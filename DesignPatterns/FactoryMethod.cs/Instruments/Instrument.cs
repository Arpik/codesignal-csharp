// Create an abstract product class named Instrument with an abstract method 'Play'.
abstract class Instrument
{
    public abstract void Play();
}

// Create a class named Guitar that inherits from Instrument and implements the 'Play' method.
class Guitar : Instrument
{
    public override void Play() => Console.WriteLine("Plays Guitar");
}

// Create a class named Piano that inherits from Instrument and implements the 'Play' method.

class Piano : Instrument
{
    public override void Play() => Console.WriteLine("Plays Piano");
}

// Create a class named Drum that inherits from Instrument and implements the 'Play' method.

class Drum : Instrument
{
    public override void Play() => Console.WriteLine("Plays Drum");
}