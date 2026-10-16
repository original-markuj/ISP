//9 вариант Высокий уровень

try
{

    Console.Write("Enter K: ");
    long k = int.Parse(Console.ReadLine());
    long i = 1;
    long iFac = 1;

    double w = 0;

    for (i = 1; i <= k; i++)
    {

        iFac = i;

        for (long c = i; c > 1; c--)
        {
            iFac *= c - 1;
        }

        w += (Math.Pow(-1, i) * ((i - 3) * (i - 3))) / iFac;

    }

    Console.WriteLine($"Answer is: {w:F3}");

}

catch(Exception e)
{
    Console.WriteLine(e.Message);
}