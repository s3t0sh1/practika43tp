using System;
class Program
{
    static void Main()
    {
        int A, B;
        int summa = 0;
        Console.Write("Введите A: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B: ");
        B = Convert.ToInt32(Console.ReadLine());
        for (int i = A; i <= B; i++)
        {
            summa = summa + i;
        }
        Console.WriteLine("Сумма = " + summa);
    }
}