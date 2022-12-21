namespace StrategyPattern.implementation;

public class Letter : INotification
{
    public void SendNotification(Contacts contacts)
    {
        Console.WriteLine($"The Message Was Printed on Paper and Sent to the Address : {contacts.HomeAddress}");
    }
}
