class Program
{
    static void Main()
    {
        // Instantiate GuitarCreator, use it to create a Guitar object, and call the 'Play' method.
        GuitarCreator guitarCreator = new GuitarCreator();
        Instrument guitar = guitarCreator.CreateInstrument();
        guitar.Play();
        
        // Instantiate PianoCreator, use it to create a Piano object, and call the 'Play' method.
        PianoCreator pianoCreator = new PianoCreator();
        Instrument piano = pianoCreator.CreateInstrument();
        piano.Play();
        
        // Instantiate DrumCreator, use it to create a Drum object, and call the 'Play' method.
        DrumCreator drumCreator = new DrumCreator();
        Instrument drum = drumCreator.CreateInstrument();
        drum.Play();
    }
}