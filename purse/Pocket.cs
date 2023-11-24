
public class Pocket
{
    public string name;
    protected List<Content> contents = new();

    public void Display()
    {
        bool hasPickedContent = false;
        while (hasPickedContent == false)
        {

            Console.WriteLine("what in this pocket do you want to use?");
            for (int i = 0; i < contents.Count; i++)
            {
                Console.WriteLine($"{i}: {contents[i].Name}");
            }
            string pick = Console.ReadLine();


            int pickNum;
            bool success = int.TryParse(pick, out pickNum);

            if (success == true && pickNum < contents.Count && pickNum >= 0)
            {
                contents[pickNum].Use();
                hasPickedContent = true;
            }
            else
            {
                Console.WriteLine("Your answer must be one number from the list, press enter to try again");
                Console.ReadLine();
            }
        }
    }
}
