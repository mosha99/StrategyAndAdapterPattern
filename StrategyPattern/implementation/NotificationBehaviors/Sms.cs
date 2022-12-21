namespace StrategyPattern.implementation;

public class Sms : INotification
{
    public void SendNotification(Contacts contacts)
    {
        Console.WriteLine($"Message Send to Mobile Number : {contacts.MobileNumber}");
    }
}
