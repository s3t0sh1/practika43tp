class overheatexception : System.Exception
{
    public overheatexception() { }
    public overheatexception(string m) : base(m) { }
    public overheatexception(string m, System.Exception i) : base(m, i) { }
}

class thermostat
{
    public void checktemperature(int t)
    {
        if (t > 100)
            throw new overheatexception("Температура превышена");
        System.Console.WriteLine("Температура нормальная: " + t);
    }
}

class program
{
    static void Main()
    {
        thermostat t = new thermostat();

        try
        {
            t.checktemperature(120);
        }
        catch (overheatexception e)
        {
            System.Console.WriteLine("Ошибка: " + e.Message);
        }

        System.Console.ReadLine();
    }
}