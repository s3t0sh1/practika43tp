double[] a = { 1.2, -3.4, 5.6, -7.8, 0, -2.1 };

int k = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] < 0)
        k++;
}

Console.WriteLine("массив:");
for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + " ");

Console.WriteLine();
Console.WriteLine("количество отрицательных элементов: " + k);