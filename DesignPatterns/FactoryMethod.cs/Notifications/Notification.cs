// Create an abstract base class named Notification with an abstract method named 'Send'.
public abstract class Notification
{
    public abstract void Send();
}

// Create a class named EmailNotification that inherits from Notification and implements the 'Send' method to output "Sending Email notification."
public class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email notification.");
    }
}

// Create a class named SMSNotification that inherits from Notification and implements the 'Send' method to output "Sending SMS notification."
public class SMSNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS notification.");
    }
}