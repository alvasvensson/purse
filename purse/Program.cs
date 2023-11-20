

Purse p = new Purse();

Console.WriteLine("What pocket of your bag do you want to look in?");
for (int i = 0; i < p.pockets.Count; i++)
{
    Console.WriteLine($"{i}: {p.pockets[i].name}");
}






Console.ReadLine();
