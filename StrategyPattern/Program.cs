List<User> users = new List<User>()
{
    new User()
        {
            Id = 1,
            Name = "Moein",
            Family = "Sha",
            Contacts = new Contacts()
            {
                Id = 1,
                Email = "mosha.dnd@gmail.com",
                HomeAddress = "Tehran - Gandy",
                MobileNumber = "09013231040"
            }
        } ,
    new User()
        {
            Id = 2,
            Name = "Ali",
            Family = "Sha",
            Contacts = new Contacts()
            {
                Id = 1,
                Email = "Ali.dnd@gmail.com",
                HomeAddress = "Tehran - Azadi",
                MobileNumber = "09013231041"
            }
        }
};




while (true)
{
    try
    {
        Console.Write("Enter User Id : ");
        int Id = int.Parse(Console.ReadLine());
        User user = users.Single(u => u.Id == Id);

        Console.Write("Enter a Send Method for User : ");
        String method = Console.ReadLine();

        Contactable contactable = new UserNotificationAdapter(user);

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
}