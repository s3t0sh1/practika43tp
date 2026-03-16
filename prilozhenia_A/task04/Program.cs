using System;
class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"({a:F2}+{b:F2})+{c:F2}={a:F2}+({b:F2}+{c:F2})");
    }
}