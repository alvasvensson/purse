

public class Instagram : App
{

    public Instagram()
    {
        Notif = "4 people liked your post";
        Name = "Instagram";
    }

    public override void Open()
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("|       Instagram         |");
        Console.WriteLine("| 4 users like your post; |");
        Console.WriteLine("|                         |");
        Console.WriteLine("| lara.croft, theratchet, |");
        Console.WriteLine("| that.doomguy, bellagoth |");
        Console.WriteLine("|                         |");
        Console.WriteLine("|                         |");
        Console.WriteLine("|                         |");
        Console.WriteLine("|                         |");
        Console.WriteLine("__________________________");
    }
}
