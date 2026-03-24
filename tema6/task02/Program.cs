delegate string dateformatter(System.DateTime d);

class Program
{
    static string shortformat(System.DateTime d)
    {
        return d.ToString("dd.MM.yyyy");
    }

    static string longformat(System.DateTime d)
    {
        return d.ToString("dd MMMM yyyy HH:mm");
    }

    static void formatdate(System.DateTime d, dateformatter f)
    {
        System.Console.WriteLine(f(d));
    }

    static void Main()
    {
        System.DateTime d = new System.DateTime(2026, 3, 24, 11, 30, 0);

        formatdate(d, shortformat);
        formatdate(d, longformat);

        System.Console.ReadLine();
    }
}