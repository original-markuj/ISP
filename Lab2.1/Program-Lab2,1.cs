//вариант 5 Высокий уровень
try
{
    Console.Write("Enter a numba (4 digits): ");
    int num = int.Parse(Console.ReadLine());

    int num1 = num % 10;
    int num2 = num / 10 % 10;
    int num3 = num / 100 % 10;
    int num4 = num / 1000 % 10;

    if (((num1 == num4) && (num2 == num3)))
    {
        Console.WriteLine($"Number {num} is a palindrome");
    }
    else
    {
        Console.WriteLine($"Number {num} is not a palindrome");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}