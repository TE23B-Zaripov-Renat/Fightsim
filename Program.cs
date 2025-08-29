static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 100;
    Console.WriteLine("Är du man eller kvinna?");
    string gender = Console.ReadLine();
    Console.WriteLine("Vad heter du?");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Vilket kön ska din enemy vara man/kvinna?");
    string gender2 = Console.ReadLine();
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
        if (gender == "man")
        {

            Console.WriteLine($"Mannen {p1Name} vann!");
        }
        else if (gender == "kvinna")
        {
            Console.WriteLine($"Kvinnan {p1Name} vann!");
        }
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine("Oavgjort!");
    }
    else
    {
        if (gender2 == "man")
        {
            Console.WriteLine($"Mannen {p2Name} vann!");
        }
        else if (gender2 == "kvinna")
        {
             Console.WriteLine($"Kvinnan {p2Name} vann!");
        }
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