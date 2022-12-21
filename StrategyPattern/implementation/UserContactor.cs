namespace StrategyPattern.implementation;

public class UserContactor : Contactable
{
    private User User { get; set; }

    public UserContactor(User user)
    {
        User = user;
    }
    public override Contacts contacts => User.GetContacts();

}
