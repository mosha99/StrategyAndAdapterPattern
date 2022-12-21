namespace StrategyPattern.implementation;

public class Mail : INotification
{
    public void SendNotification(Contacts contacts , string message)
    {
        Console.WriteLine($"Message Send to Email address : {contacts.Email}");
        Console.WriteLine($"Message is : {message}");

    }
}
