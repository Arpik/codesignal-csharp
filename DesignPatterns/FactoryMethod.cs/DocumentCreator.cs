// Abstract class representing a Document Creator
abstract class DocumentCreator
{
    // Abstract method to be implemented by derived classes
    public abstract Document CreateDocument();
}

// WordDocumentCreator class inheriting from DocumentCreator
class WordDocumentCreator : DocumentCreator
{
    // Implementation of the CreateDocument method to create a Word document
    public override Document CreateDocument() => new WordDocument();
}

// ExcelDocumentCreator class inheriting from DocumentCreator
class ExcelDocumentCreator : DocumentCreator
{
    // Implementation of the CreateDocument method to create an Excel document
    public override Document CreateDocument() => new ExcelDocument();
}

// TODO: Add the new PdfDocumentCreator class here with `CreateDocument` method, that returns a new PdfDocument.

class PdfDocumentCreator : DocumentCreator
{
    // Implementation of the CreateDocument method to create an Excel document
    public override Document CreateDocument() => new PdfDocument();
}