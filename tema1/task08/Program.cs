using System;
class Program
{
    static void Main()
    {
        int K, N;
        Console.Write("введите K: ");
        K = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите N: ");
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(K);
        }
    }
}