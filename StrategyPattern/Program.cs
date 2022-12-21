List<User> users = new List<User>()
{
    new User()
        {
            Id = 1,
            Name = "Moein",
            Family = "Sha",
            Email = "mosha.dnd@gmail.com",
            HomeAddress = "Tehran - Gandy",
            MobileNumber = "09013231040"

        } ,
    new User()
        {
            Id = 2,
            Name = "Ali",
            Family = "Sha",
            Email = "Ali.dnd@gmail.com",
            HomeAddress = "Tehran - Azadi",
            MobileNumber = "09013231041"

        }
};

Factory factory = new Factory()
{
    Id = 1,
    Name = "MoFact",
    Mail = "Mo.fact@gmail.com",
    Description = "factory for iphone",
    Address = "tehran valiAsr",
    Admin = users[0],
};

Action<Contactable, string> SendByAllMethod = (contactable, Message) =>
 {
     contactable.SetNotificationMethod("Sms");
     contactable.SendNotification(Message);

     contactable.SetNotificationMethod("mail");
     contactable.SendNotification(Message);

     contactable.SetNotificationMethod("Letter");
     contactable.SendNotification(Message);
 };

Contactable contactable = new UserContactor(users[0]);
SendByAllMethod(contactable, "Hello Coustomer");

Console.WriteLine("**************");

contactable = new UserContactor(new FactoryAdapter(factory));
SendByAllMethod(contactable, "Helo Factory");

/*while (true)
{
    try
    {
        Console.Write("Enter User Id : ");
        int Id = int.Parse(Console.ReadLine());
        User user = users.Single(u => u.Id == Id);

        Console.Write("Enter a Send Method for User : ");
        String method = Console.ReadLine();


        contactable.SetNotificationMethod(method);
        contactable.SendNotification();

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine();
    Console.WriteLine("*************************************************************");
    Console.WriteLine();
}*/