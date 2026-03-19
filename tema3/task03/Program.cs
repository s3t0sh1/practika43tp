abstract class ticket
{
    public string name;
    public double price;
    public int seat;
    public ticket(string n, double p, int s)
    {
        name = n;
        price = p;
        seat = s;
    }
}
sealed class concert : ticket
{
    public concert(string n, double p, int s) : base(n, p, s) { }
}
sealed class theater : ticket
{
    public theater(string n, double p, int s) : base(n, p, s) { }
}
class office
{
    public ticket[] t;
    public office(ticket[] t1)
    {
        t = t1;
    }
    public double sum()
    {
        double s = 0;
        for (int i = 0; i < t.Length; i++)
            s += t[i].price;
        return s;
    }
    public ticket max()
    {
        ticket m = t[0];
        for (int i = 0; i < t.Length; i++)
            if (t[i].price > m.price)
                m = t[i];
        return m;
    }
}
class program
{
    static void Main()
    {
        ticket[] a ={
            new concert("c",100,1),
            new theater("t",150,2)
        };
        office o = new office(a);
        System.Console.WriteLine(o.sum());
        ticket m = o.max();
        System.Console.WriteLine(m.name + " " + m.price);
        System.Console.ReadLine();
    }
}