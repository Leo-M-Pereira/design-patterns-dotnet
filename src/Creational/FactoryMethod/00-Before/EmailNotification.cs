namespace FactoryMethod.Before;

public sealed class EmailNotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}
