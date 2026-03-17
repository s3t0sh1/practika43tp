using System;
class Program
{
  static void Main()
    {
      int number;
      Console.Write("введите четырехзначное число: ");
      number = Convert.ToInt32(Console.ReadLine());
      int first = number / 1000;
      int second = (number / 100) % 10;
        if (first > second)
            Console.WriteLine("первая цифра больше");
        else if (second > first)
            Console.WriteLine("вторая цифра больше");
        else
            Console.WriteLine("первая и вторая цифры равны");
    }
}