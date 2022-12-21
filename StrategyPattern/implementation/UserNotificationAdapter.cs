namespace StrategyPattern.implementation;

public class UserNotificationAdapter : Contactable
{
    private User User { get; set; }

    public UserNotificationAdapter(User user)
    {
        User = user;
    }
    public override Contacts contacts => User.Contacts;

}
