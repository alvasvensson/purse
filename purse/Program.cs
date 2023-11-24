

Purse p = new Purse();
bool hasPickedPocket = false;


while (hasPickedPocket == false)
{
    Console.WriteLine("What pocket of your bag do you want to look in?");
    for (int i = 0; i < p.pockets.Count; i++)
    {
        Console.WriteLine($"{i}: {p.pockets[i].name}");
    }

    string pick = Console.ReadLine();


    int pickNum;
    bool success = int.TryParse(pick, out pickNum);

    if (success == true && pickNum < p.pockets.Count && pickNum >= 0)
    {
        p.pockets[pickNum].Display();
        hasPickedPocket = true;
    }
    else
    {
        Console.WriteLine("Your answer must be one number from the list, press enter to try again");
        Console.ReadLine();
    }
}




Console.ReadLine();
