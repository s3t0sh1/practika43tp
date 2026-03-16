using System;
class Program
{
    static void Main()
    {
        Console.Write("введите трехзначное число: ");
        int numb = Convert.ToInt32(Console.ReadLine());

        if (numb < 100 || numb > 999)
        {
            Console.WriteLine("ошибка: число должно быть трехзначным.");
            return;
        }
        int first = numb / 100;
        int second = (numb / 10) % 10;
        int third = numb % 10;
        int result = second * 100 + first * 10 + third;
        Console.WriteLine($"число после перестановки первой и второй цифр: {result}");
    }
}