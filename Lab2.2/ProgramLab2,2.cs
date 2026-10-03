//Вариант 5 Средний уровень

try
{
    Console.Write("Enter variant of parameters (1-3): ");
    int var = int.Parse(Console.ReadLine());

    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());

    double y = 0;

    double a = 0;
    double b = 0;
    double c = 0;

    switch (var)
    {
        case 1:
            a = 4.2; b = 5.3; c = 1.5;
            break;
        case 2: 
            a = -0.35; b = 1.8; c = -1.8; 
            break;
        case 3: 
            a = 2.8; b = -0.6; c = 2; 
            break;
        default: Console.WriteLine("Nopers"); break;
    }

    double e1 = Math.Exp(a + b);
    double e2 = Math.Exp(x);

    if (e1 > e2)
    {
        var = 1;
    }
    else if (e1 == e2)
    {
        var = 2;
    }
    else if (e1 < e2)
    {
        var = 3;
    }

    switch (var)
    {
        case 1:
            y = Math.Sin(e1) + x * x;
            break;
        case 2:
            y = Math.Atan(a * b * c) + Math.Cbrt(x);
            break;
        case 3:
            y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
            break;
    }

    Console.WriteLine($"Your answer is: {y}");

}
catch (Exception e)
{
    Console.WriteLine("Nopers (error)");
    Console.WriteLine(e.Message);
}