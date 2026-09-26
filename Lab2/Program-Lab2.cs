//Вариант 5 Высокий уровень
try
{
    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Enter y: ");
    double y = double.Parse(Console.ReadLine());
    double r = Math.Sqrt(x * x + y * y);

    double y1 = x + 1;
    double y2 = x - 1;

    Console.WriteLine($"Answer is: {((r <= 1) && (r >= 0)) && ((y >= y1) || (y <= y2))}");
}
catch
{
    Console.WriteLine("Minor spelling mistake");
    Environment.Exit(404);
}