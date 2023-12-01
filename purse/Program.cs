
Purse p = new Purse();
string playagain = "yes";

while (playagain == "yes")
{
    int pickNum = 0;
    pickNum = p.Pick(p, pickNum);
    p.pockets[pickNum].Display();

    Console.WriteLine("Do you want to look again?");
    playagain = Console.ReadLine();
}



Console.ReadLine();

