using System;
class Program
{
    static void Main()
    {
        int n;
        Console.Write("введите количество секунд: ");
        n = Convert.ToInt32(Console.ReadLine());
        int hours = n / 3600;
        Console.WriteLine("полных часов прошло: " + hours);
    }
}