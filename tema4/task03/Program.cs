class program
{
    static int sumofdigits(int n)
    {
        if (n < 10)
            return n;
        return n % 10 + sumofdigits(n / 10);
    }
    static void Main()
    {
        int n = 1234;
        System.Console.WriteLine(sumofdigits(n));
        System.Console.ReadLine();
    }
}
