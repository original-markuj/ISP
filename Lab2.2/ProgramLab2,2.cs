try
{
    Console.Write("Enter postcard's theme (1-3): ");
    int theme = int.Parse(Console.ReadLine());

    if (theme < 1 || theme > 3)
    {
        Console.WriteLine("Nopers");
        Environment.Exit(0);
    }

    Console.Write("Enter postcard's variation (1-3): ");
    int var = int.Parse(Console.ReadLine());

    if (var < 1 || var > 3)
    {
        Console.WriteLine("Nopers");
        Environment.Exit(0);
    }

    Console.Write("Enter amount of money (1 - 5gr, 2 - 10gr, 3 - 20gr): ");
    int money = int.Parse(Console.ReadLine());

    if (money < 1 || money > 3)
    {
        Console.WriteLine("Nopers");
        Environment.Exit(0);
    }


    string kup1 = "1gr";
    string kup2 = "2gr";
    string kup3 = "5gr";
    string kup4 = "10gr";

    switch (theme)
    {
        case 1: Console.Write("Merry Chirstmas theme, ");
            break;
        case 2: Console.Write("Happy Birthday theme, ");
            break;
        case 3: Console.Write("Day of Nation Defenders theme, ");
            break;
    }
    switch (var)
    {
        case 1:
            Console.Write("Variation A, ");
            break;
        case 2:
            Console.Write("Variation B, ");
            break;
        case 3:
            Console.Write("Variation C, ");
            break;
    }
    switch (money)
    {
        case 1:
            Console.Write($"Your change is: {kup2} + {kup1}");
            break;
        case 2:
            Console.Write($"Your change is: {kup4}");
            break;
        case 3:
            Console.Write($"Your change is: {kup4} + {kup3} + {kup2} + {kup1}");
            break;
    }

}
catch
{
    Console.WriteLine("Nopers");
}