//Вариант 13 Высокий уровень
int[] mas = [12, 2, 4, 12, 5, 8, 42, 32, 8, 10, 112, 54, 3, 1];

int minimum = 999;
int index = 0;

int min(int[] x)
{
    int k = minl(0);
    return x[k];
}

int minl(int k)
{
    if (k < mas.Length - 1) k++;
    else return index;
    if (mas[k] < minimum)
    {
        minimum = mas[k];
        index = k;
    }
    minl(k);
    return index;
}

Console.WriteLine(min(mas));