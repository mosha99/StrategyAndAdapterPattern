namespace StrategyPattern.implementation;

public class Sms : INotification
{
    public void SendNotification(Contacts contacts , string message)
    {
        Console.WriteLine($"Message Send to Mobile Number : {contacts.MobileNumber}");
        Console.WriteLine($"Message is : {message}");

    }
}
