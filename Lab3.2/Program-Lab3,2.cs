//Вариант 9

try
{
    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Enter amount of operations: ");
    double n = double.Parse(Console.ReadLine());

    double answer = 0;
    double fac = 0;
    double num = 0;

    for (int i = 0; i < n; i++)
    {

        num = 1 + 4 * i;
        fac = num;

        for (double c = num; c > 1; c--)
        {
            fac *= c - 1;
        }

        answer += Math.Pow(x, num) / fac;

    }

    Console.WriteLine($"Answer: {answer:f3}");

}

catch(Exception e)
{
    Console.WriteLine(e.Message);
}