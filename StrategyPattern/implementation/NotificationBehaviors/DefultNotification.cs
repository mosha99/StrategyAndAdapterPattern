namespace StrategyPattern.implementation;

public class DefultNotification : INotification
{
    public void SendNotification(Contacts contacts , string message)
    {
        throw new Exception("Method Not Selected");
    }
}
