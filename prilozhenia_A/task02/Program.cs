using System;
class Program
{
    static void Main()
    {
        Console.Write("введите трехзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 100 || num > 999)
        {
            Console.WriteLine("ошибка: число должно быть трехзначным.");
            return;
        }
        int hundreds = num / 100;
        int tens = (num/ 10) % 10;
        int ones = num % 10;
        int reversed = ones * 100 + tens * 10 + hundreds;
        Console.WriteLine($"число, прочитанное справа налево: {reversed}");
    }
}