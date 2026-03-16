using System;
class Program
{
    static void Main()
    {
        Console.Write("введите сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double d = Math.Sqrt(a * a + b * b);
        double s = a * b;
        double p = 2 * (a + b);
        Console.WriteLine($"Периметр P = {p:F2}");
        Console.WriteLine($"Площадь S = {s:F2}");
        Console.WriteLine($"Диагональ d = {d:F2}");
    }
}