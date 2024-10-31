// Sealed Logger class, preventing inheritance
public sealed class Logger
{
    // Private constructor to prevent instantiation from outside
    private Logger() {}

    // Lazy initialization to ensure thread-safety
    private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

    // Public property to access the single instance
    public static Logger Instance => instance.Value;

    // The Log method to accepts a second parameter 'level' for severity level
    public void Log(string message, string severity)
    {
        // Prefix the message with the severity level "<level>: <message>"
        Console.WriteLine($"{severity}: {message}");
    }
}

class Program
{
    static void Main()
    {
        // Update the Log calls to include the severity level as the second parameter
        Logger.Instance.Log("Singleton pattern example with Logger.", "INFO"); // "INFO"
        Logger.Instance.Log("This is a warning message.", "WARNING"); // "WARNING"
        Logger.Instance.Log("This is an error message.", "ERROR"); // "ERROR"
    }
}