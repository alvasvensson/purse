public class Makeup : Content
{
    public string colour;
    public string placement;

    public override void Use()
    {
        Console.WriteLine($"Your {placement} now has a pretty, {colour} shine!");
        Console.ReadLine();
    }
}
