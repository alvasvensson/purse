
public class Weather : App
{
    public Weather()
    {
        Notif = "Your can expect rain this afternoon";
        Name = "Weather";
    }

    public override void Open()
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("        Weather          ");
        Console.WriteLine("Today: Mostly Rain ");
        Console.WriteLine($"{DateTime.Today.AddDays(1).ToString("ddd, dd/MM")}: Mostly Cloudy");
        Console.WriteLine($"{DateTime.Today.AddDays(2).ToString("ddd, dd/MM")}: Rain all day");
        Console.WriteLine("__________________________");
    }
}
