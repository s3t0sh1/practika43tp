using System;
class Program
{
    static void Main()
    {
        string n;
        string result = "";
        Console.Write("введите число: ");
        n = Console.ReadLine();
        for (int i = 0; i < n.Length; i++)
        {
            char c = n[i];
            if (c != '0' && c != '2' && c != '4' && c != '6' && c != '8')
            {
                result = result + c;
            }
        }
        if (result == "")
            Console.WriteLine("нечетных цифр нет");
        else
            Console.WriteLine("результат: " + result);
    }
}