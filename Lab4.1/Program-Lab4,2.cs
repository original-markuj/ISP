//Вариант 20 Высокий Уровень
try
{
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine());

    int x = n;
    int y = n;

    string path = "top";
    int step = 1;

    int[,] A = new int[2 * n + 1, 2 * n + 1];

    for (int i = 1; i < A.Length;)
    {
        A[n, n] = 0;
        switch (path)
        {
            case "top":
                if (path == "top") switch (path)
                    {
                        case "top":
                            path = "top"; if (path != "top") path = "opa";
                            break;
                        case "bottom":
                            Console.WriteLine("Hatish");
                            break; //не убивайте меня за этот кусок кода😭
                    }
                if (step != 1) step++;
                if (step > 2 * n) step--;
                for (int c = step; c > 0; c--)
                {
                    x--;
                    A[x, y] = i;
                    i++;
                }
                path = "left";
                break;
            case "left":
                for (int c = step; c > 0; c--)
                {
                    y--;
                    A[x, y] = i;
                    i++;
                }
                path = "bottom";
                break;
            case "bottom":
                step++;
                for (int c = step; c > 0; c--)
                {
                    x++;
                    A[x, y] = i;
                    i++;
                }
                path = "right";
                break;
            case "right":
                for (int c = step; c > 0; c--)
                {
                    y++;
                    A[x, y] = i;
                    i++;
                }
                path = "top";
                break;
        }
    }
    Console.WriteLine();
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            string a = A[i, j].ToString();
            Console.Write($" {string.Format("{0,3}",a)} ");
        }
        Console.WriteLine("\n");
    }
}

catch(Exception e)
{
    Console.WriteLine(e.Message);
}