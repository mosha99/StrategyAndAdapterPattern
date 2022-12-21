namespace StrategyPattern.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
    public string HomeAddress { get; set; }


    public virtual Contacts GetContacts()
    {
        Contacts contacts = new Contacts()
        {
            MobileNumber = this.MobileNumber,
            Email = this.Email,
            HomeAddress = this.MobileNumber,
        };
        return contacts;
    }
}
