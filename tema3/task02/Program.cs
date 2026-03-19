static class mathoperations
{
    public static double sum(double[] a)
    {
        double s = 0;
        for (int i = 0; i < a.Length; i++)
            s += a[i];
        return s;
    }
}
class program
{
    static void Main()
    {
        double[] a = { 1, 2, 3 };
        System.Console.WriteLine(mathoperations.sum(a));
        System.Console.ReadLine();
    }
}

