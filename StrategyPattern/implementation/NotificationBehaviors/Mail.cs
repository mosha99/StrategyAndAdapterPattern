namespace StrategyPattern.implementation;

public class Mail : INotification
{
    public void SendNotification(Contacts contacts)
    {
        Console.WriteLine($"Message Send to Email address : {contacts.Email}");
    }
}
