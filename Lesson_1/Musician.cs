using System;

public class Musician
{
    public string name;
    public string instrument;
    public int yearsActive;

    // TODO: Add a new field 'yearsActive' to capture the number of years the musician has been active

    public Musician(string name, string instrument, int yearsActive)
    {
        this.name = name;
        this.instrument = instrument;
        // TODO: Initialize the yearsActive field
        this.yearsActive = yearsActive;
    }

    // TODO: Update the copy constructor to include the yearsActive field in the copy
    public Musician(Musician other)
    {
        name = other.name;
        instrument = other.instrument;
        yearsActive = other.yearsActive;
    }

     // TODO: Update the Display method to include the yearsActive field in the output
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Instrument {instrument}, Active years {yearsActive}");
    }
}

