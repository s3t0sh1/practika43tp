using System;
class Program
{
    static void Main()
    {
        int inch = 2;
        double cm;
        while (inch <= 24)
        {
            cm = inch * 2.54;
            Console.WriteLine(inch + " дюйм = " + cm + " см");
            inch = inch + 2;
        }
    }
}

