//Вариант 20 Высокий уровень

// debug tables

//int[] m = new int[5] { 1, 2, 4, 8, 16 }; // regular progression

//int[] m = new int[5] { 1, 1, 2, 4, 8 }; // last progression

//int[] m = new int[6] { 2, 4, 8, 1, 2, 4 }; // double progression


Random rng = new Random();

int[] m = new int[rng.Next(5, 10)];

for (int i = 0; i < m.Length; i++)
{
    m[i] = rng.Next(1, 50);
}

int mult = 0;
int prevNum = 0;
bool isGProgression = false;
int absMult = 0;

for (int i = 0; i < m.Length; i++)
{
    Console.WriteLine(m[i]);
}

foreach (int i in m)
{
    if (mult > 0 && (prevNum * mult) == i && absMult >= 0)
    {
        absMult = mult;
    }
    else if (mult > 0 && (prevNum * mult) != i) absMult = -1;
    if (prevNum > 0)
    {
        mult = i / prevNum;
    }

    prevNum = i;
}

if (absMult > 0) isGProgression = true;

Console.WriteLine();

switch (isGProgression)
{
    case true:
        Console.WriteLine($"Last geometry progression: {absMult}");
        break;

    case false:
        Console.WriteLine("No progress detected");
        break;
}