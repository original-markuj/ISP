//did ts during class

bool end = false;

string[] color = new string[3] { "black", "red", "green" };

try
{
    while (true)
    {
        Console.Write("Enter game's name (slots, roulette; break for program end): ");
        string game = Console.ReadLine();

        decimal moneyAmt = 100;

        Console.WriteLine();

        switch (game)
        {
            case "slots":
                while (true)
                {
                    try
                    {

                        Console.WriteLine($"Money amount: {moneyAmt}");

                        Console.Write("Enter sum of bet: ");
                        decimal bet = decimal.Parse(Console.ReadLine());

                        if (bet <= 0) continue;
                        if (bet > moneyAmt) continue;

                        moneyAmt -= bet;

                        Random rng = new Random();
                        int one = rng.Next(1, 10);
                        int two = rng.Next(1, 10);
                        int three = rng.Next(1, 10);

                        int randomInt = rng.Next(7, 16 + 1);

                        for (int i = 0; i < randomInt; i++)
                        {
                            int oneR = rng.Next(1, 10);
                            int twoR = rng.Next(1, 10);
                            int threeR = rng.Next(1, 10);
                            Console.WriteLine($"{oneR} {twoR} {threeR}");
                            await Task.Delay(rng.Next(50, 150));
                        }

                        Console.WriteLine();

                        Console.WriteLine($"{one} {two} {three}");


                        if (one == three && one == two && one == 7)
                        {
                            Console.WriteLine("JACKPOOOOOOT!!!!!");
                            moneyAmt += bet * 99;
                        }
                        else if (one == three && one == two)
                        {
                            Console.WriteLine("Win!!!");
                            moneyAmt += bet * 7;
                        }
                        else if (one == two || one == three || two == three)
                        {
                            Console.WriteLine("Mini win!");
                            moneyAmt += bet * 3;
                        }
                        else
                        {
                            Console.WriteLine($"You lost {bet}");
                        }

                        if (moneyAmt <= 0)
                        {
                            Console.WriteLine("You lost!");
                            Console.WriteLine();
                            break;
                        }
                        else if (moneyAmt >= 1000000)
                        {
                            Console.WriteLine("You win!");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine();
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                break;

            case "roulette":
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Money amount: {moneyAmt}");

                        Console.Write("Enter sum of bet: ");
                        decimal bet = decimal.Parse(Console.ReadLine());

                        if (bet <= 0) continue;
                        if (bet > moneyAmt) continue;

                        Console.Write("Bet color(red, black, green): ");
                        string clr = Console.ReadLine();

                        if (!(clr == "red" || clr == "black" || clr == "green")) continue;

                        Console.Write("Bet number(1-37, enter 0 to not bet on num): ");
                        int betNum = int.Parse(Console.ReadLine());

                        if (betNum < 0 || betNum > 37) continue;

                        moneyAmt -= bet;

                        Random rng = new Random();

                        string rngColor = color[rng.Next(0, 3)];
                        int colorNum = rng.Next(1, 13);

                        if (!(rngColor == "green" && colorNum == 1)) rngColor = color[rng.Next(0, 2)];

                        int rngNum = rng.Next(1, 38);

                        int rollAmt = rng.Next(15, 25);

                        for (int i = 0; i <= rollAmt; i++)
                        {
                            Console.Write($" {rng.Next(1, 38)} ");
                            await Task.Delay(rng.Next(50, 100));
                        }

                        Console.WriteLine($" {rngNum} {rngColor}");


                        if (clr == "green" && rngColor == "green")
                        {
                            Console.WriteLine("JACKPOOOOOT!!!!!");
                            moneyAmt += bet * 10;
                        }
                        else if (clr == rngColor && rngNum == betNum)
                        {
                            Console.WriteLine("Big win!!!");
                            moneyAmt += bet * 8;
                            clr = "";
                            betNum = 0;
                        }
                        else if (rngNum == betNum && clr == "green" && rngColor == "green")
                        {
                            Console.WriteLine("Win!");
                            moneyAmt += bet * 2;
                        }
                        else if (clr == rngColor && betNum == 0)
                        {
                            Console.WriteLine("Win!");
                            moneyAmt += bet * 2;
                        }
                        else
                        {
                            Console.WriteLine($"You lost {bet}!");
                        }


                        if (moneyAmt <= 0)
                        {
                            Console.WriteLine("You lost!");
                            Console.WriteLine();
                            break;
                        }
                        else if (moneyAmt >= 1000000)
                        {
                            Console.WriteLine("You win!");
                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                break;

            case "break":
                end = true;
                break;

            default: Console.WriteLine("Enter proper name"); break;
        }

        if (end) break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}