
public class Weather : App
{
    public Weather()
    {
        Notif = "Your can expect rain this afternoon";
    }

    public override void Open()
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("|        Weather          |");
        Console.WriteLine("| Today:  |");
        Console.WriteLine("| Tomorrow:  |");
        Console.WriteLine("| :  |");
    }
}
