class warehouse
{
    public product[] p;

    public warehouse(product[] p1)
    {
        p = p1;
    }

    public product[] zero()
    {
        return System.Array.FindAll(p, x => x.stock == 0);
    }

    public product max()
    {
        product m = p[0];
        for (int i = 0; i < p.Length; i++)
            if (p[i].price > m.price)
                m = p[i];
        return m;
    }
}

class program
{
    static void Main()
    {
        product[] a ={
            new product{name="a",price=10,stock=0},
            new product{name="b",price=20,stock=5}
        };

        warehouse w = new warehouse(a);

        var z = w.zero();
        for (int i = 0; i < z.Length; i++)
            z[i].show();

        var m = w.max();
        System.Console.WriteLine(m.name);

        System.Console.ReadLine();
    }
}