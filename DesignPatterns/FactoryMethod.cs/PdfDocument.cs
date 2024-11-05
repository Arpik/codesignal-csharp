abstract class Document
{
    // Abstract method to be implemented by derived classes
    public abstract void Open();
}

// WordDocument class inheriting from Document
class WordDocument : Document
{
    // Implementation of the Open method for Word documents
    public override void Open() => Console.WriteLine("Opening Word document.");
}

// ExcelDocument class inheriting from Document
class ExcelDocument : Document
{
    // Implementation of the Open method for Excel documents
    public override void Open() => Console.WriteLine("Opening Excel document.");
}

// TODO: Add the new PdfDocument class here with `Open` method, that says "Opening PDF document."