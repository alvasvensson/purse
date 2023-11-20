public class Makeup : Content
{
    public string colour;
    public string placement;

    public void putOn()
    {
        Console.WriteLine($"Your {placement} now has a pretty, {colour} shine!");
        Console.ReadLine();
    }
}
