class Program
{
    static void Main()
    {
        DocumentCreator creator = new WordDocumentCreator();
        Document doc = creator.CreateDocument();
        doc.Open();

        creator = new ExcelDocumentCreator();
        doc = creator.CreateDocument();
        doc.Open();

        // Create and open a Word document
        DocumentCreator wordCreator = new WordDocumentCreator();
        Document wordDoc = wordCreator.CreateDocument();
        wordDoc.Open();

        // Create and open an Excel document
        DocumentCreator excelCreator = new ExcelDocumentCreator();
        Document excelDoc = excelCreator.CreateDocument();
        excelDoc.Open();

        // Create and open a PDF document
        DocumentCreator pdfCreator = new PdfDocumentCreator();
        Document pdfDoc = pdfCreator.CreateDocument();
        pdfDoc.Open();
    }

}