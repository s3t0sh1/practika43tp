delegate int[] sortmethod(int[] a);

class bubblesort
{
    public int[] sort(int[] a)
    {
        int[] b = (int[])a.Clone();

        for (int i = 0; i < b.Length - 1; i++)
            for (int j = 0; j < b.Length - 1 - i; j++)
                if (b[j] > b[j + 1])
                {
                    int t = b[j];
                    b[j] = b[j + 1];
                    b[j + 1] = t;
                }

        return b;
    }
}

class quicksort
{
    public int[] sort(int[] a)
    {
        int[] b = (int[])a.Clone();
        qsort(b, 0, b.Length - 1);
        return b;
    }

    void qsort(int[] a, int l, int r)
    {
        int i = l, j = r;
        int x = a[(l + r) / 2];

        while (i <= j)
        {
            while (a[i] < x) i++;
            while (a[j] > x) j--;

            if (i <= j)
            {
                int t = a[i];
                a[i] = a[j];
                a[j] = t;
                i++;
                j--;
            }
        }

        if (l < j) qsort(a, l, j);
        if (i < r) qsort(a, i, r);
    }
}

class Program
{
    static void show(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
            System.Console.Write(a[i] + " ");
        System.Console.WriteLine();
    }

    static void Main()
    {
        int[] a = { 5, 2, 8, 1, 3 };

        bubblesort b = new bubblesort();
        quicksort q = new quicksort();

        sortmethod s;

        s = b.sort;
        int[] r1 = s(a);
        show(r1);

        s = q.sort;
        int[] r2 = s(a);
        show(r2);

        System.Console.ReadLine();
    }
}