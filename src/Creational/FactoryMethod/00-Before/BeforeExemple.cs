namespace FactoryMethod.Before;

public static class BeforeExample
{
    public static void Run()
    {
        var service = new NotificationService();

        service.Send(
            "email",
            "user@example.com",
            "Welcome to the Factory Method study!");

        service.Send(
            "sms",
            "+5511999999999",
            "Your verification code is 123456.");
    }
}
