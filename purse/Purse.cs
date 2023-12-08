
public class Purse
{
    // Lista på alla fickor i väskan
    public List<Pocket> pockets = new();
    public Purse()
    {
        pockets.Add(new MakeupBag());
        pockets.Add(new TinyPocket());
    }

    public int Pick(Purse p, int pickNum)
    {
        bool hasPickedPocket = false;
        while (hasPickedPocket == false)
        {
            //Frågar användaren vad hen vill göra och skriver ut namnet på alla fickor i listan från Pocket-klassen
            Console.WriteLine("What pocket of your bag do you want to look in?");
            for (int i = 0; i < p.pockets.Count; i++)
            {
                Console.WriteLine($"{i}: {p.pockets[i].name}");
            }

            //kollar vad användaren har skrivit och försöker göra om det till en int 
            string pick = Console.ReadLine();
            bool success = int.TryParse(pick, out pickNum);

            //om användaren har skrivit bara en siffra får man gå vidare och då körs Display metoden för den fickan användaren har valt
            if (success == true && pickNum < p.pockets.Count && pickNum >= 0)
            {
                hasPickedPocket = true;
            }
            //annars så körs while-loopen igen
            else
            {
                Console.WriteLine("Your answer must be one number from the list, press enter to try again");
                Console.ReadLine();
            }
        }

        return pickNum;
    }


}
