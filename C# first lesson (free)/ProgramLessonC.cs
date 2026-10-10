//Console.WriteLine("Hello, I'm Falsity. Say your name, foolish men");

//string name = Console.ReadLine();

//if (name == "Den")
//{
//    Console.WriteLine($"Sorry {name}, I'm Lord Verity");
//}
//else
//{
//    Console.WriteLine($"I fooled you {name}, I'm Lord Verity");
//}
//Console.Write("Write X ");

//double x = Convert.ToInt32(Console.ReadLine());

//Console.Write("Write Y ");

//double y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{x} + {y} = {x + y}");

//if (x)
//{
//    Console.WriteLine($"{x} + {y} = {x + y}");
//}

//double x;
//float a = 1;
//float b = -1;
//float c = -2;

//x = ((-b - Math.Sqrt(Math.Pow(b,2) - 4*a*c))/(2*a));

//Console.WriteLine(x);

//float x = 2;

//Console.Write($"Enter exp for {x}: ");

//double exp = Convert.ToDouble(Console.ReadLine());

//double y = Math.Exp(x * exp);

//Console.WriteLine($"Your exp for {x} is: {y}");

//Console.WriteLine($"Do not go home until you finish reading the value of e. {Math.E:f50}");

//try
//{
//    Console.Write("Hey, it's me, it's Verity! ");
//    string x = Console.ReadLine();
//    if (x == "Ask me anything")
//    {
//        Console.WriteLine("I have a question.");
//        Console.Write("I know about a million things! ");
//        string y = Console.ReadLine();
//        if (y == "I'll do everything")
//        {       
//            Console.WriteLine("Alright!");
//        }
//        else
//        {
//            Console.WriteLine("Evil Verity is coming for you");
//        };
//    }
//    else
//    { 
//        Console.WriteLine("Evil Verity is coming for you");
//    };
//}
//catch
//{
//    Console.WriteLine("How did we get here? (Error)");
//};
//try
//{
//    Console.Write("Enter numba (up to 3 digits): ");
//    int num = int.Parse(Console.ReadLine());

//    int a = num % 10;
//    int b = num / 10 % 10;
//    int c = num / 100 % 10;

//    int num1 = 3;
//    int num2 = 6;

//    if ((a == num1 || b == num1 || c == num1) || (a == num2 || b ==num2 || c ==num2))
//    {
//        Console.WriteLine("Yay :)");
//    }
//    else
//    {
//        Console.WriteLine("Not yay >:(");
//    }
//}
//catch
//{

//    Console.WriteLine("Minor spelling mistake");

//};
//try
//{
//    Console.Write("Enter amount of rubles: ");
//    decimal num = decimal.Parse(Console.ReadLine());

//    decimal x = num;

//    if (x > 5 && x < 21) x = 5;
//    else if (x >= 21) x = x % 10;
//    if (x > 5) x = 5;

//    switch (x)
//    {
//        case 0: Console.WriteLine($"{num} рублей"); break;
//        case 1: Console.WriteLine($"{num} рубль"); break;
//        case 2: case 3: case 4: Console.WriteLine($"{num} рубля"); break;
//        case 5: Console.WriteLine($"{num} рублей"); break;
//        default: Console.WriteLine("Nopers"); break;
//    }
//}
//catch 
//{
//    Console.WriteLine("Nopers");
//};

//try
//{
//    int i = 1;

//    Console.Write("Enter x: ");
//    int x = int.Parse(Console.ReadLine());

//    int mon1 = 1;
//    int mon2 = 2;
//    int mon3 = 4;
//    int mon4 = 8;

//    int n1 = 0;
//    int n2 = 0;
//    int n3 = 0;
//    int n4 = 0;

//    for (i = 1; i > 0;)
//    {
//        x = x - mon4;
//        i = x;
//        if (x >= 0)
//        {
//            n4++;
//        }
//        else
//        {
//            x = x + mon4;
//        }
//    }

//    for (i = 1; i > 0;)
//    {
//        x = x - mon3;
//        i = x;
//        if (x >= 0)
//        {
//            n3++;
//        }
//        else
//        {
//            x = x + mon3;
//        }
//    }

//    for (i = 1; i > 0;)
//    {
//        x = x - mon2;
//        i = x;
//        if (x >= 0)
//        {
//            n2++;
//        }
//        else
//        {
//            x = x + mon2;
//        }
//    }

//    for (i = 1; i > 0;)
//    {
//        x = x - mon1;
//        i = x;
//        if (x >= 0)
//        {
//            n1++;
//        }
//        else
//        {
//            x = x + mon1;
//        }
//    }

//    Console.WriteLine($"{mon4 * n4}gr + {mon3 * n3}gr + {mon2 * n2}gr + {mon1 * n1}gr");

//}
//catch
//{
//    Console.WriteLine("Nopers");
//}

//try
//{
//    Console.Write("Enter x: ");
//    double x = double.Parse(Console.ReadLine());
//    int i = 1;
//    double s = 1;
//    while (i <= x)
//    {
//        s = s * i;
//        i = i + 1;
//    }

//    Console.WriteLine($"{x}! = {s}");

//    for (s = s; s > 0; s -= 7)
//    {
//        Console.WriteLine(s);
//        Console.Write($"{s} - 7 = ");
//    }

//    Console.WriteLine(s);

//}
//catch
//{

//}


//try
//{
//    string[,] alphabet =
//    {
//        {"a","b","c","d","e","f" },
//        {"u","v","w","x","y","z" }
//    };
//    for (int i = 1; i > 0;)
//    {
//        foreach (var item in alphabet)
//        {
//            Random rand = new Random();
//            int x = rand.Next(1,12);
//            Console.WriteLine(alphabet.GetValue(x));
//        }
//        Console.WriteLine();
//    }
//}


//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//double c = 0;
//double s = 0;
//double n = 0;

//do
//{

//    try
//    {
//        Console.Write("Enter n: ");
//        n = double.Parse(Console.ReadLine());

//        if (n < 0) break;

//        s += n;

//        c++;

//    }

//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (n >= 0);

//s /= c;

//Console.WriteLine($"Average of numbers = {s:f4}");

//try
//{
    
//    long k = 0;
//    long k3 = 0;
//    long kLast = 0;
//    long kEven = 0;
//    long kSumGreaterFive = 0;
//    long kMultGreaterSeven = 1;
//    long kZeroFive = 0;

//    Console.Write("Enter n: ");
//    long n = int.Parse(Console.ReadLine());

//    long last = n % 10;

//    while (n != 0)
//    {
//        k = n % 10;
//        if (k == 3) k3++;
//        if (k == last) kLast++;
//        if (k % 2 == 0) kEven++;
//        if (k > 5) kSumGreaterFive += k;
//        if (k > 7) kMultGreaterSeven *= k;
//        if (k == 5 || k == 0) kZeroFive++;
//        n /= 10;
//    }

//    if (kMultGreaterSeven == 1) kMultGreaterSeven = 0;

//    Console.WriteLine($"Threes: {k3}");
//    Console.WriteLine($"Last repeat: {kLast}");
//    Console.WriteLine($"Evens: {kEven}");
//    Console.WriteLine($"Sum greater than five: {kSumGreaterFive}");
//    Console.WriteLine($"Mult greater than seven: {kMultGreaterSeven}");
//    Console.WriteLine($"Zeros and fives: {kZeroFive}");

//}

//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


for (int i = 5; i <= 25; i += 5)
{
    for (int j = 6; j - i / 5 > 0; j--)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}