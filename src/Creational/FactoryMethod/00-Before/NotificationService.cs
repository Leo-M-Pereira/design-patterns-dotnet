namespace FactoryMethod.Before;

public sealed class NotificationService
{
    public void Send(string type, string recipient, string message)
    {
        if (type == "email")
        {
            var notification = new EmailNotification();
            notification.Send(recipient, message);
        }
        else if (type == "sms")
        {
            var notification = new SmsNotification();
            notification.Send(recipient, message);
        }
        else
        {
            throw new ArgumentException(
                $"Unsupported notification type: {type}",
                nameof(type));
        }
    }
}
