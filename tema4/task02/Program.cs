class program
{
    static void invdigits(ref int k)
    {
        int n = k;
        int rev = 0;
        while (n > 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        k = rev;
    }
    static void Main()
    {
        int a = 123;
        int b = 4567;
        int c = 890;
        int d = 12;
        int e = 3456;
        invdigits(ref a);
        invdigits(ref b);
        invdigits(ref c);
        invdigits(ref d);
        invdigits(ref e);
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.ReadLine();
    }
}