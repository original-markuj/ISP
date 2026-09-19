
//This is my program btw. I'm the one who paying for it

//This is my variant btw. I'm the one who paying for it

try
{
    //Вариант 3.27
    Console.Write("Enter a number with 4 or 5 digits: ");
    int num = int.Parse(Console.ReadLine());

    int a = num % 10;
    int b = num % 100 / 10;
    int c = num % 1000 / 100;
    int d = num % 10000 / 1000;
    int e = num % 100000 / 10000;

    Console.WriteLine($"Sum of digits is: {a+b+c+d+e}");
}
catch (Exception ex) 
{
    Console.WriteLine("El idiote");
    Console.WriteLine(ex.Message);
    Console.WriteLine("El cartele de Mexicano is le cominge el uo'yrue");
}