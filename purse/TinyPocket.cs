
public class TinyPocket : Pocket
{
    public TinyPocket()
    {
        name = "Tiny Pocket";
        contents.Add(new Keys());
        contents.Add(new Wallet());
    }
}
