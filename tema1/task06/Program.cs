using System;
class Program
{
    static void Main()
    {
        int channel;
        Console.Write("введите номер канала: ");
        channel = Convert.ToInt32(Console.ReadLine());

        switch (channel)
        {
            case 1:
                Console.WriteLine("Популярные программы канала 1:");
                Console.WriteLine("Новости");
                Console.WriteLine("Время");
                Console.WriteLine("Поле чудес");
                break;

            case 2:
                Console.WriteLine("Популярные программы канала 2:");
                Console.WriteLine("Вести");
                Console.WriteLine("60 минут");
                Console.WriteLine("О самом главном");
                break;

            case 3:
                Console.WriteLine("Популярные программы канала 3:");
                Console.WriteLine("Сегодня");
                Console.WriteLine("Следствие вели...");
                Console.WriteLine("Ты не поверишь!");
                break;

            case 4:
                Console.WriteLine("Популярные программы канала 4:");
                Console.WriteLine("Comedy Club");
                Console.WriteLine("Однажды в России");
                Console.WriteLine("Битва экстрасенсов");
                break;

            case 5:
                Console.WriteLine("Популярные программы канала 5:");
                Console.WriteLine("Новости");
                Console.WriteLine("Сериал");
                Console.WriteLine("Документальный фильм");
                break;

            default:
                Console.WriteLine("Такого канала нет");
                break;
        }
    }
}