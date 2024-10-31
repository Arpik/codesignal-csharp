// Sealed Logger class, preventing inheritance
// Sealed Logger class, preventing inheritance
public sealed class Logger
{
    // Private constructor to prevent instantiation from outside
    private Logger() 
    {
        // Initialize counter to 1
        logCount = 1;
    }

    // Lazy initialization to ensure thread-safety
    private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

    // Public property to access the single instance
    public static Logger Instance => instance.Value;

    // Integer counter to keep track of log messages
    private int logCount;

    // Method to log messages to the console
    public void Log(string message)
    {
        // Print the message along with the log count in format: "{message} (Log count: {logCount})"
        Console.WriteLine($"{message} (Log count: {logCount})");

        // Increment the counter
        logCount++;
    }
}

class Program
{
    static void Main()
    {
        // Access the Logger instance and log messages
        Logger.Instance.Log("First log message.");
        Logger.Instance.Log("Second log message.");
    }
}