static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 100;
    Console.WriteLine("Vad heter du?");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Vad ska din enemy heta?");
    string p2Name = Console.ReadLine();

    while (p1Hp > 0 && p2Hp > 0)
    {
        Console.WriteLine($"{p1Name}: {p1Hp}");
        Console.WriteLine($"{p2Name}: {p2Hp}");
        p2Hp -= Random.Shared.Next(10, 25); // Alex slår Calin
        p1Hp -= Random.Shared.Next(10, 25); // Calin slår Alex
        Console.ReadLine();
    }
    if (p1Hp > 0)
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine("Oavgjort!");
    }
    else
    {
        Console.WriteLine($"{p2Name} vann!");
    }
    Console.ReadLine();
}

bool spelaIgen = true;

while (spelaIgen)
{
    Fight();

    Console.WriteLine("Vill du spela igen? (ja/nej)");
    string svar = Console.ReadLine();

    if (svar == "nej")
    {
        spelaIgen = false;
    }
   
}