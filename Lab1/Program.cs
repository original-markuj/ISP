//Console.Write("Enter x: ");
//double Fx = Convert.ToDouble(Console.ReadLine());
//double Fk = (Math.Sqrt(Math.Pow(3 + Fx, 6) - Math.Log(Fx))) / (Math.Exp(0) + Math.Asin(6 * Fx * Fx));
//Console.WriteLine($"k = {Fk:f5}");

//Console.Write("Enter x: ");
//double Sx = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter a: ");
//double Sa = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter c: ");
//double Sc = Convert.ToDouble(Console.ReadLine());
//double L = (Math.Sqrt(Math.Pow(Math.E, Sx) - Math.Pow(Math.Cos(Math.Pow(Sx,2) * Math.Pow(Sa,5)), 4)) + Math.Pow(Math.Atan(Sa - Math.Pow(Sx,5)),4)) / (Math.Exp(Math.Sqrt(Math.Abs(Sa + Sx * Math.Pow(Sc,4)))));

//Console.WriteLine($"L = {L:f5}");

//Console.Write("Enter y: ");
//double y = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter h: ");
//double h = Convert.ToDouble(Console.ReadLine());
//double A = (Math.Tan(Math.Pow(y,3) - Math.Pow(h,4)) + Math.Pow(h,2)) / (Math.Pow(Math.Sin(h + y),3));

//Console.WriteLine($"A = {A:f5}");


//Вариант 8

Console.Write("Enter x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter c: ");
double c = Convert.ToDouble(Console.ReadLine());

double P = (Math.Pow(a, 5) + Math.Pow(Math.Sin(y - c), 4)) / (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
Console.WriteLine($"P = {P:f5}");