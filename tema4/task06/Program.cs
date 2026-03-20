class program
{
    static void nextdate(ref int d, ref int m, ref int y)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            days[1] = 29;
        d++;
        if (d > days[m - 1])
        {
            d = 1;
            m++;

            if (m > 12)
            {
                m = 1;
                y++;
            }
        }
    }
    static void Main()
    {
        int d1 = 28, m1 = 2, y1 = 2024;
        int d2 = 31, m2 = 12, y2 = 2023;
        int d3 = 30, m3 = 4, y3 = 2023;
        nextdate(ref d1, ref m1, ref y1);
        nextdate(ref d2, ref m2, ref y2);
        nextdate(ref d3, ref m3, ref y3);
        System.Console.WriteLine(d1 + "." + m1 + "." + y1);
        System.Console.WriteLine(d2 + "." + m2 + "." + y2);
        System.Console.WriteLine(d3 + "." + m3 + "." + y3);
        System.Console.ReadLine();
    }
}