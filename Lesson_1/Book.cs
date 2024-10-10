// TODO: Define the Book class
public class Book
{
    // Create public fields 'title' and 'author'
    public string title;
    public string author;
    
    // Implement a constructor that initializes both fields
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    
    // Implement a copy constructor with a 'Book' parameter
    public Book(Book other)
    {
        this.title = other.title;
        this.author = other.author;
    }
    
    // Implement a 'Display' method that prints 'title' and 'author'
    public void Display()
    {
        Console.WriteLine($"Title: {title}, Director: {author}");
    }
}

// class Program
// {
//     static void Main()
//     {
//         // TODO: Create a Book object with title "1984" and author "George Orwell"
//         Book book = new Book("1984", "George Orwell");
        
//         // TODO: Call the 'Display' method on this object to print the details
//         book.Display();
        
//         // TODO: Create a copy of the first object using the copy constructor
//         Book bookCopy = new Book(book);
        
//         // TODO: Call the 'Display' method on the copied object to print the details
//         bookCopy.Display();
//     }
// }