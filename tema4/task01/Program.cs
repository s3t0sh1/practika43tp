class program
{
    static void sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
            for (int j = 0; j < a.Length - 1 - i; j++)
                if (a[j] > a[j + 1])
                {
                    int t = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = t;
                }
    }
    static void Main()
    {
        int[] a = { 5, 2, 8, 1, 3 };
        sort(a);
        for (int i = 0; i < a.Length; i++)
            System.Console.Write(a[i] + " ");
        System.Console.ReadLine();
    }
}