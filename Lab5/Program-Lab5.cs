//Вариант 20 Высокий уровень

Random rng = new Random();

int randNum = rng.Next(50, 100);

char[] A = new char[randNum];
char[] repeat = new char[randNum];

int c = 0;

string text = "фйжрвныуйъэюсауыдесягьоанкпмячяваспаренйяваспаренйдлоанкпмячяваспаренйяваспаренйдлоанкпмячшйычякхждв";

for (int i = 0; i < A.Length; i++)
{
    A[i] = text[rng.Next(1, 100)];
}

for (int i = 0; i < A.Length; i++)
{
    if (repeat.Contains(A[i])) continue;
    repeat[i] = A[i];
    for (int j = 0; j < A.Length; j++)
    {
        if (repeat[i] == A[j]) c += 1;
    }
    string num = "";
    if ((c >= 10 && c <= 20) || (c % 10 <= 1 || c >= 5)) num = "раз";
    else if (c % 10 >= 2 && c % 10 <= 4) num = "раза";
    Console.WriteLine($"{repeat[i]} - {c} {num}");
    c = 0;
}

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"{A[i]} ");
}