class program
{
    static string formatstring(string s)
    {
        return s.ToUpper();
    }
    static string formatstring(int n)
    {
        return "Число: " + n;
    }
    static void Main()
    {
        string s = "hello";
        int n = 10;
        System.Console.WriteLine(formatstring(s));
        System.Console.WriteLine(formatstring(n));
        System.Console.ReadLine();
    }
}