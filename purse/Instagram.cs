

public class Instagram : App
{

    public Instagram()
    {
        Notif = "6 people liked your post";
    }

    public override void Open()
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("|       Instagram         |");
        Console.WriteLine("| 6 users like your post; |");
    }
}
