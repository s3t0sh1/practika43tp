using System;

class Program
{
    static void Main()
    {
        Console.Write("Цена одного килограмма яблок (руб.) -> ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Вес яблок (кг) =  ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double cost = price * weight;

        Console.WriteLine($"Стоимость покупки: {cost:F2} руб.");
    }
}