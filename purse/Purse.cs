
public class Purse
{
    public List<Pocket> pockets = new();
    public Purse()
    {
        pockets.Add(new MakeupBag());
        pockets.Add(new TinyPocket());
    }


}
