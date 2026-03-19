class a
{
    int a1;
    int b1;
    public a(int a, int b)
    {
        a1 = a;
        b1 = b;
    }
    public double f1()
    {
        return (-b1 + 1.0 / a1) / 3;
    }
    public int f2()
    {
        return (int)System.Math.Pow(a1 + b1, 3);
    }
}
class program
{
    static void Main()
    {
        a x = new a(2, 3);
        System.Console.WriteLine(x.f1());
        System.Console.WriteLine(x.f2());
        System.Console.ReadLine();
    }
}