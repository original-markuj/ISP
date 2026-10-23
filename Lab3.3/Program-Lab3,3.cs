//Вариант 9 Высокий уровень
try
{

    Console.Write("Enter amount of summation operations: "); //В задании бесконечность, вместо неё ставить обычное число
    int limit = int.Parse(Console.ReadLine());

    double x = 0.5;
    double facK = 0;
    double fX = 0;
    int k = 1;

    for (x = x; x <= 2; x += 0.15)
    {
        for (k = k; k <= limit; k++)
        {

            facK = k;

            for (double c = facK; c > 1; c--)
            {
                facK *= c - 1;
            }

            fX += (Math.Pow(-3, k) * Math.Pow(x, k)) / facK;
        }

        Console.WriteLine($"f({x:f2}) = {fX:f3}");
        fX = 0;
        k = 1;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

