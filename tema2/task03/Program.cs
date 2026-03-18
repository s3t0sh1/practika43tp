Console.Write("введите n: ");
int n = int.Parse(Console.ReadLine());

if (n <= 0 || n >= 10)
{
    Console.WriteLine("n должно быть меньше 10");
    return;
}

Console.Write("введите a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите b: ");
int b = int.Parse(Console.ReadLine());

int[,] m = new int[n, n];
Random r = new Random();

Console.WriteLine("матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        m[i, j] = r.Next(a, b + 1);
        Console.Write(m[i, j] + "\t");
    }
    Console.WriteLine();
}

int s = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (m[i, j] % 2 == 0)
            s += m[i, j];
    }
}

Console.WriteLine("сумма четных элементов: " + s);

for (int j = 0; j < n; j++)
{
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        if (m[i, j] > 0)
            k++;
    }
    Console.WriteLine("в столбце " + (j + 1) + " положительных элементов: " + k);
}
