//Вариант 9 Высокий уровень

long n = 1;

long mult = 1;

while (n != 0)
{
    try
    {
        Console.Write("Enter n (enter 0 to end program): ");
        n = long.Parse(Console.ReadLine());

        if (n == 0) break;

        mult *= n;
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

if (mult == 1) mult = 0;

Console.WriteLine($"Multiplication of all numbers = {mult}");