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

try
{
    Console.Write("Hey, it's me, it's Verity! ");
    string x = Console.ReadLine();
    if (x == "Ask me anything")
    {
        Console.WriteLine("I have a question.");
        Console.Write("I know about a million things! ");
        string y = Console.ReadLine();
        if (y == "I'll do everything")
        {       
            Console.WriteLine("Alright!");
        }
        else
        {
            Console.WriteLine("Evil Verity is coming for you");
        };
    }
    else
    { 
        Console.WriteLine("Evil Verity is coming for you");
    };
}
catch
{
    Console.WriteLine("How did we get here? (Error)");
};