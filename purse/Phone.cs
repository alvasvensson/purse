
public class Phone : Content
{
    List<App> notifs = new List<App>();
    public Phone()
    {
        Name = "Phone";
        notifs.Add(new Instagram());
        notifs.Add(new Weather());
    }
    DateTime currentDateTime = DateTime.Now;

    public override void Use()
    {
        Console.WriteLine("_______________________");
        Console.WriteLine("|                      |");
        Console.WriteLine($"|  {currentDateTime} |");
        Console.WriteLine("|                      |");
        Console.WriteLine($"|  {notifs.Count} new notifications |");
        Console.WriteLine("|                      |");
        Console.WriteLine("|                      |");
        Console.WriteLine("|                      |");
        Console.WriteLine("|                      |");
        Console.WriteLine("_______________________");
        Console.WriteLine("Do you want to look at your notifications? (yes/no)");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            for (int i = 0; i < notifs.Count; i++)
            {
                Console.WriteLine($"{i}: {notifs[i].Notif}");
            }
            Console.WriteLine("Do you want to look closer on any of the notifications? If so, write it's number");
            string pick = Console.ReadLine();
            int pickNum;
            bool success = int.TryParse(pick, out pickNum);

            if (success == true && pickNum < notifs.Count && pickNum >= 0)
            {
                notifs[pickNum].Open();
            }
        }

    }
}
