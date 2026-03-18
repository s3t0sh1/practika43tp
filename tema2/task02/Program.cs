Console.Write("введите k: ");
int k = int.Parse(Console.ReadLine());

int[] a = new int[100];
Random r = new Random();

Console.WriteLine("исходный массив:");
for (int i = 0; i < 100; i++)
{
    a[i] = r.Next(0, 100);
    Console.Write(a[i] + " ");
}

Array.Sort(a);

Console.WriteLine();
Console.WriteLine("отсортированный массив:");
for (int i = 0; i < 100; i++)
    Console.Write(a[i] + " ");

Console.WriteLine();
int p = Array.BinarySearch(a, k);

if (p >= 0)
    Console.WriteLine("число " + k + " найдено, индекс: " + p);
else
    Console.WriteLine("число " + k + " не найдено");

int max = a[0];
for (int i = 1; i < 100; i++)
{
    if (a[i] > max)
        max = a[i];
}

int[] b = new int[100];

for (int i = 0; i < 100; i++)
{
    if (a[i] == max)
        b[i] = 1;
    else
        b[i] = 0;
}

Console.WriteLine("максимальный элемент: " + max);
Console.WriteLine("новая последовательность:");
for (int i = 0; i < 100; i++)
    Console.Write(b[i] + " ");