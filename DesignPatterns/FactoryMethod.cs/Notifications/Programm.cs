class Program
{
    static void Main()
    {
        // The creator classes to create both types of notifications and call their 'Send' methods.
        NotificationCreator emailNotificationCreator = new EmailNotificationCreator();
        Notification emailNotification = emailNotificationCreator.CreateNotification();
        emailNotification.Send();
        
        NotificationCreator smsNotificationCreator = new SMSNotificationCreator();
        Notification smsNotification = smsNotificationCreator.CreateNotification();
        smsNotification.Send();

    }
}