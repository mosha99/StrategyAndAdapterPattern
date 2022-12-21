namespace StrategyPattern.implementation;

public class DefultNotification : INotification
{
    public void SendNotification(Contacts contacts)
    {
        throw new Exception("Method Not Selected");
    }
}
