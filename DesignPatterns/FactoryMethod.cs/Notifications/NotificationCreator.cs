// An abstract base class named NotificationCreator with an abstract method named 'CreateNotification'.
abstract class NotificationCreator
{
    public abstract Notification CreateNotification();
}

// Class named EmailNotificationCreator that inherits from NotificationCreator and implements the 'CreateNotification' method to return a new EmailNotification.

class EmailNotificationCreator : NotificationCreator
{
    public override Notification CreateNotification() => new EmailNotification();
}

// Class named SMSNotificationCreator that inherits from NotificationCreator and implements the 'CreateNotification' method to return a new SMSNotification.
class SMSNotificationCreator : NotificationCreator
{
    public override Notification CreateNotification() => new SMSNotification();
}