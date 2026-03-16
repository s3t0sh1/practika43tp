using System;
class Program
{
    static void Main()
    {
        double x = 6.4;
        double y = Math.Exp(x) / Math.Cos(Math.Sqrt(x) - 1) + (2 * Math.Atan(x * x)) / (1 - x);
        Console.WriteLine($"x = {x:F1}");
        Console.WriteLine($"y = {y:F6}");
    }
} // задание №8 является дубликатом этого задания