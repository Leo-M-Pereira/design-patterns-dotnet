namespace FactoryMethod.Before;

public sealed class SmsNotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}
