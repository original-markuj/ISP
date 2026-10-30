//Вариант 13 Средний уровень
string str = "They call me Lord, like I'm Verity";

char[] n = str.ToArray();

for (int i = 0; i < str.Length; i++)
{
    if (i + 1 >= str.Length) break;
    n[i] = str[i + 1];
    n[i + 1] = str[i];
    i++;
}
str = string.Join("", n);

Console.WriteLine(str);