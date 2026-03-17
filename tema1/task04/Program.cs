using System;
class Program
{
    static void Main()
    {
        double x, y;
        Console.Write("введите x: ");
        x = Convert.ToDouble(Console.ReadLine());
        if (x < 0.1)
        {
          y = Math.Sqrt(Math.Abs(2 * x * x + Math.Sin(x) + 1));
          Console.WriteLine("y = " + y);
        }
        else if (x == 0.1)
        {
          y = 2 * x + Math.Exp(x);
          Console.WriteLine("y = " + y);
        }
        else
        {
          Console.WriteLine("для данного x функция не задана");
        }
    }
}