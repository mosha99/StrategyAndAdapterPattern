namespace StrategyPattern.Abstractions;
public abstract class Contactable
{
    public Contactable()
    {
    }

    public abstract Contacts contacts { get;}
    public INotification NotificationBehavior { get; private set; } = new DefultNotification();

    public void SetNotificationMethod(string method)
    {
        switch (method.ToLower())
        {
            case "sms": SetNotificationMethod( new Sms()); break;
            case "mail": SetNotificationMethod( new Mail()); break;
            case "letter": SetNotificationMethod( new Letter()); break;
            default:
                throw new Exception("Method Not Find !");
        }
    }

    public void SetNotificationMethod(INotification NotificationMethod)
    {
        if(NotificationMethod == null)
            throw new Exception("Method Not Find !");

        NotificationBehavior = NotificationMethod;
    }
    public void SendNotification()
    {
        NotificationBehavior.SendNotification(contacts);
    }
}

