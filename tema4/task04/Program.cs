using System.Collections.Generic;
static class ext
{
    public static double median(this List<int> a)
    {
        a.Sort();
        int n = a.Count;
        if (n % 2 == 1)
            return a[n / 2];
        else
            return (a[n / 2 - 1] + a[n / 2]) / 2.0;
    }
}
class program
{
    static void Main()
    {
        List<int> a = new List<int> { 7, 1, 3, 9, 5 };
        System.Console.WriteLine(a.median());
        System.Console.ReadLine();
    }
}
