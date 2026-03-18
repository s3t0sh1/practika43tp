int[][] a = new int[2][];
a[0] = new int[] { 1, 2 };
a[1] = new int[] { 3, 4, 5 };

int[][] b = new int[3][];
b[0] = new int[] { 6 };
b[1] = new int[] { 7, 8 };
b[2] = new int[] { 9, 10, 11 };

int[][] c = new int[a.Length + b.Length][];

for (int i = 0; i < a.Length; i++)
    c[i] = a[i];

for (int i = 0; i < b.Length; i++)
    c[a.Length + i] = b[i];

Console.WriteLine("объединенный массив:");
for (int i = 0; i < c.Length; i++)
{
    for (int j = 0; j < c[i].Length; j++)
        Console.Write(c[i][j] + " ");
    Console.WriteLine();
}