interface ifilter<t>
{
    System.Collections.Generic.IEnumerable<t> filter(System.Collections.Generic.IEnumerable<t> items, System.Func<t, bool> p);
}

class simplefilter<t> : ifilter<t>
{
    public System.Collections.Generic.IEnumerable<t> filter(System.Collections.Generic.IEnumerable<t> items, System.Func<t, bool> p)
    {
        System.Collections.Generic.List<t> r = new System.Collections.Generic.List<t>();

        foreach (t x in items)
            if (p(x))
                r.Add(x);

        return r;
    }
}

class repository<t>
{
    System.Collections.Generic.List<t> items = new System.Collections.Generic.List<t>();

    public void add(t x)
    {
        items.Add(x);
    }

    public void remove(t x)
    {
        items.Remove(x);
    }

    public System.Collections.Generic.IEnumerable<t> getall()
    {
        return items;
    }
}

class filtermanager<t>
{
    public void printfiltered(System.Collections.Generic.IEnumerable<t> items, System.Func<t, bool> p)
    {
        simplefilter<t> f = new simplefilter<t>();
        var r = f.filter(items, p);

        foreach (t x in r)
            System.Console.WriteLine(x);
    }
}

class program
{
    static void Main()
    {
        repository<int> r = new repository<int>();

        r.add(1);
        r.add(2);
        r.add(3);
        r.add(4);
        r.add(5);

        filtermanager<int> f = new filtermanager<int>();
        f.printfiltered(r.getall(), x => x % 2 == 0);

        System.Console.ReadLine();
    }
}