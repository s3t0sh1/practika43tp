class mysortedlist<tkey, tvalue> where tkey : System.IComparable<tkey>
{
    tkey[] keys = new tkey[100];
    tvalue[] values = new tvalue[100];
    int count = 0;

    public void add(tkey key, tvalue value)
    {
        keys[count] = key;
        values[count] = value;
        count++;
        sort();
    }

    void sort()
    {
        for (int i = 0; i < count - 1; i++)
            for (int j = 0; j < count - 1 - i; j++)
                if (keys[j].CompareTo(keys[j + 1]) > 0)
                {
                    tkey k = keys[j];
                    keys[j] = keys[j + 1];
                    keys[j + 1] = k;

                    tvalue v = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = v;
                }
    }

    public void remove(tkey key)
    {
        int index = -1;

        for (int i = 0; i < count; i++)
            if (keys[i].CompareTo(key) == 0)
            {
                index = i;
                break;
            }

        if (index == -1)
            return;

        for (int i = index; i < count - 1; i++)
        {
            keys[i] = keys[i + 1];
            values[i] = values[i + 1];
        }

        count--;
    }

    public tvalue find(tkey key)
    {
        for (int i = 0; i < count; i++)
            if (keys[i].CompareTo(key) == 0)
                return values[i];

        return default(tvalue);
    }

    public void show()
    {
        for (int i = 0; i < count; i++)
            System.Console.WriteLine(keys[i] + " " + values[i]);
    }
}

class sortedlistmanager<tkey, tvalue> where tkey : System.IComparable<tkey>
{
    public mysortedlist<tkey, tvalue> list = new mysortedlist<tkey, tvalue>();

    public void additem(tkey key, tvalue value)
    {
        list.add(key, value);
    }

    public void removeitem(tkey key)
    {
        list.remove(key);
    }

    public void finditem(tkey key)
    {
        System.Console.WriteLine(list.find(key));
    }

    public void showall()
    {
        list.show();
    }
}

class program
{
    static void Main()
    {
        sortedlistmanager<int, string> s = new sortedlistmanager<int, string>();

        s.additem(3, "c");
        s.additem(1, "a");
        s.additem(2, "b");

        s.showall();
        s.finditem(2);
        s.removeitem(1);
        s.showall();

        System.Console.ReadLine();
    }
}