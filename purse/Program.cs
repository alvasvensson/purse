﻿
Purse p = new Purse();
string playagain = "yes";

while (playagain == "yes")
{
    int pickNum = 0;
    pickNum = p.Pick(p, pickNum);
    p.pockets[pickNum].Display();

    Console.WriteLine("Do you want to look in your purse again? (yes/no)");
    playagain = Console.ReadLine();
}



Console.ReadLine();

