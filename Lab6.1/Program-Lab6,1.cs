//Вариант 13 Средний Уровень
using Library;

double[,] matrix = new double[5,5];
double[] sec = new double[5];

double biggest = 0;
double lowest = 0;
int index = 0;

double a(int i, int j)
{
    double answer = (Math.Log(2,5) * (i * i + j * j) - Math.Pow(Math.E, Math.E)) / (1.5 * (i * i) - Math.Pow(-2.3,i));
    return answer;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = a(i, j);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (matrix[i, i] > biggest)
    {
        biggest = matrix[i, i];
    }
}

lowest = biggest;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (matrix[i,i] < lowest)
    {
        lowest = matrix[i,i];
        index = i;
    }
}

for (int i = 0; i < matrix.GetLength(1); i++)
{
    sec[i] = matrix[index, i];
}

Console.WriteLine(Class1.G(sec));