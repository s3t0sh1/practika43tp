using System;
class Program
{
    static void Main()
    {
        Console.Write("введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (b * b - 4 < 0)
        {
            Console.WriteLine("ошибка: подкоренное выражение b^2 - 4 должно быть >= 0.");
            return;
        }
        if (b + 2 <= 0)
        {
            Console.WriteLine("ошибка: выражение b + 2 должно быть > 0.");
            return;
        }
        if (b * b - 4 + b + 2 <= 0)
        {
            Console.WriteLine("ошибка: подкоренное выражение b^2 - 4 + b + 2 должно быть > 0.");
            return;
        }
        double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(b * b - 4)) /
                    Math.Sqrt(b * b - 4 + b + 2);
        double z2 = 1 / Math.Sqrt(b + 2);
        Console.WriteLine($"z1 = {z1:F6}");
        Console.WriteLine($"z2 = {z2:F6}");
        Console.WriteLine($"разница = {Math.Abs(z1 - z2):F10}");
    }
}