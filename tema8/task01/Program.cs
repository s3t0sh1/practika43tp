class contact
{
    public string name;
    public string phonenumber;

    public contact(string n, string p)
    {
        name = n;
        phonenumber = p;
    }
}

class phonebook
{
    System.Collections.Hashtable h = new System.Collections.Hashtable();

    public void add(contact c)
    {
        h[c.name] = c.phonenumber;
    }

    public void remove(string name)
    {
        h.Remove(name);
    }

    public void find(string name)
    {
        if (h.ContainsKey(name))
            System.Console.WriteLine(name + ": " + h[name]);
        else
            System.Console.WriteLine("Контакт не найден");
    }

    public void showall()
    {
        foreach (System.Collections.DictionaryEntry x in h)
            System.Console.WriteLine(x.Key + ": " + x.Value);
    }
}

class program
{
    static void Main()
    {
        phonebook p = new phonebook();

        p.add(new contact("Аня", "111"));
        p.add(new contact("Борис", "222"));
        p.add(new contact("Вика", "333"));

        p.find("Борис");
        p.remove("Аня");
        p.showall();

        System.Console.ReadLine();
    }
}