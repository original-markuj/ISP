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


//for (int i = 5; i <= 25; i += 5)
//{
//    for (int j = 6; j - i / 5 > 0; j--)
//    {
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}


//try
//{

//    Console.Write("Enter k: ");
//    int k = int.Parse(Console.ReadLine());
//    double A = 1;

//    for (int j = 1; j <= k; j ++)
//    {
//        if (j == 3) continue;
//        double s = 0;
//        for (int i = j; i <= k + 1; i++)
//        {
//            if (i == 1) continue;
//            s += Math.Pow(i - 5, 1 / 3.0);
//        }
//    }
//}

//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//int i = 4;

//for (int c = i; c > 1; c--)
//{
//    i *= c - 1;
//}

//Console.WriteLine(i);

//Random rng = new Random();
//int n = rng.Next(2,10);

//int[,] mass = new int[n,n];

//for (int i = 0; i < mass.GetLength(0); i++)
//{
//    for (int j = 0; j < mass.GetLength(1); j++)
//    {
//        mass[i, j] = rng.Next(-3, 3);
//        Console.Write($" {mass[i, j]} ");
//    }
//    Console.WriteLine();
//}

//double aa = 0;

//for (int i = 0;i < mass.GetLength(0); i++)
//{
//    if (mass[i,i] < 0) mass[i,i] = Math.Abs(mass[i,i]);
//    aa += mass[i,i];;
//}

//aa /= mass.GetLength(0);

//Console.WriteLine($"{aa:f2}");

//for (int i = 25; i < 128; i++)
//{
//    Console.Write((char)i + " ");
//}

//char[,] matrix = new char[5, 7];

//Random rng = new Random();

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        matrix[i, j] = (char)rng.Next(26, 128);
//        Console.Write($"{matrix[i,j]} ");
//    }
//    Console.WriteLine();
//}

//int sum = 0;

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        if (char.IsDigit(matrix[i,j]))
//        {
//            sum += int.Parse(matrix[i, j].ToString());
//        }
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine($"\n {sum}");

int x = 24;
int y = 16;

string[,] space = new string [y, x];

int locationX = x / 2;
int locationY = y / 2;

int eLocationX = locationX / 2;
int eLocationY = locationY / 2;

bool canMove = true;
bool gameOver = false;

string up = "u";
string down = "d";
string left = "l";
string right = "r";

Random rng = new Random();


void aiWork()
{
    bool XY = rng.Next(0, 2) == 1;
    if (eLocationX == locationX) XY = true;
    else if (eLocationY == locationY) XY = false;
    switch (XY)
    {
        case bool a when (!XY && eLocationX < locationX) == true:
            eLocationX++;
            break;
        case bool a when (!XY && eLocationX > locationX) == true:
            eLocationX--;
            break;
        case bool a when (XY && eLocationY < locationY) == true:
            eLocationY++;
            break;
        case bool a when (XY && eLocationY > locationY) == true:
            eLocationY--;
            break;
    }
}
void FieldSetUp()
{
    if (gameOver)
    {
        Console.WriteLine("Game Over!");
        return;
    }
    Console.Clear();
    if (canMove) aiWork();
    for (int i = 0; i < space.GetLength(0); i++)
    {
        for (int j = 0; j < space.GetLength(1); j++)
        {
            switch (canMove)
            {
                case bool a when ((j == 0 || j == space.GetLength(1) - 1) || (i == 0 || i == space.GetLength(0) - 1)):
                    space[i, j] = "o ";
                    break;
                case bool a when (locationX == j && locationY == i):
                    space[i, j] = "I ";
                    break;
                case bool a when (eLocationX == j && eLocationY == i):
                    space[i, j] = "X ";
                    break;
                case bool a when (eLocationX == locationX && eLocationY == locationY):
                    gameOver = true;
                    break;
                default:
                    space[i, j] = "  ";
                    break;
            }
           
        }
    }

    for (int i = 0; i < space.GetLength(0); i++)
    {
        for (int j = 0; j < space.GetLength(1); j++)
        {
            Console.Write(space[i,j]);
        }
        Console.WriteLine();
    }
    canMove = true;
}
void check(string dir,int numDir)
{
    switch (dir)
    {
        case string d when dir == up:
            if (locationY - 1 <= 0) canMove = false;
            break;
        case string d when dir == left:
            if (locationX - 1 <= 0) canMove = false;
            break;
        case string d when dir == down:
            if (locationY + 1 >= space.GetLength(0) - 1) canMove = false;
            break;
        case string d when dir == right:
            if (locationX + 1 >= space.GetLength(1) - 1) canMove = false;
            break;
    }
    move(dir,numDir);
}

void move(string dir, int numDir)
{
    if (numDir == null) numDir = 1;
    for (int i = 0; i < numDir; i++)
    {
        if (!canMove) dir = "";
        switch (dir)
        {
            case string d when dir == up:
                locationY--;
                break;
            case string d when dir == left:
                locationX--;
                break;
            case string d when dir == down:
                locationY++;
                break;
            case string d when dir == right:
                locationX++;
                break;
            case string d when dir == "boom":
                if (eLocationX - 1 == locationX || eLocationX + 1 == locationX || eLocationY - 1 == eLocationY || eLocationY + 1 == eLocationY)
                {
                    boom();
                }
                break;
            default:
                break;
        }
        FieldSetUp();
    }    
}

void boom()
{

}

FieldSetUp();

while (true)
{
    try
    {
        Console.Write("Move: ");
        string moveDir = Console.ReadLine();
        string dir = moveDir[0].ToString();

        int numDir = int.Parse(moveDir.Substring(1));

        if (gameOver)
        {
            Console.WriteLine("Game Over!");
            break;
        }

        check(dir, numDir);
    }

    catch(Exception e)
    {
        Console.WriteLine(e.Message);
        await Task.Delay(500);
    }
}