using System;
class Program
{
    static void Main()
    {
        int a, b, c;
        Console.Write("введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите третье число: ");
        c = Convert.ToInt32(Console.ReadLine());
        if (a == b || a == c || b == c)
            Console.WriteLine("истина");
        else
            Console.WriteLine("ложь");
    }
}