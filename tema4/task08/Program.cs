class Program
{
    static void formatdate(in System.DateTime d, out string s)
    {
        s = d.ToString("dd.MM.yyyy");
    }

    static void formatdate(in System.DateTime d, bool t, out string s)
    {
        if (t)
            s = d.ToString("dd.MM.yyyy HH:mm");
        else
            s = d.ToString("dd.MM.yyyy");
    }

    static void Main()
    {
        string a;
        string b;

        System.DateTime d1 = new System.DateTime(2021, 1, 1);
        System.DateTime d2 = new System.DateTime(2021, 1, 1, 15, 30, 0);

        formatdate(in d1, out a);
        formatdate(in d2, true, out b);

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);

        System.Console.ReadLine();
    }
}