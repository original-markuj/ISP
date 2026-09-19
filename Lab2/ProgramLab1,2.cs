using System.Linq.Expressions;

//Вариант 8 Высокий Уровень

try {
    Console.Write("Enter x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Enter y: ");
    double y = double.Parse(Console.ReadLine());
    double Z = Math.Sqrt(x*x + y*y);
    double S = x * y / 2;
    Console.WriteLine($"Hypotenuse is: {Z}");
    Console.WriteLine($"Area is: {S}");
}
catch(Exception ex){
    Console.WriteLine("Say hi to new error");
    Console.WriteLine(ex.Message);
} 