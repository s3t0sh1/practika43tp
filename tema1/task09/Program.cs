using System;
class Program
{
    static void Main()
    {
        double a = 0;
        double b = 1;
        int M = 20;
        double h = (b - a) / M;
        double x = a;
        double y;
        for (int i = 1; i <= M; i++)
        {
            y = Math.Atan(x);
            Console.WriteLine("x = " + x + "   y = " + y);
            x = x + h;
        }
    }
}