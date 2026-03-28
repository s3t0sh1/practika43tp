using System;

interface itransportstrategy
{
    void go();
}

class cartransport : itransportstrategy
{
    public void go()
    {
        System.Console.WriteLine("Поездка на машине");
    }
}

class biketransport : itransportstrategy
{
    public void go()
    {
        System.Console.WriteLine("Поездка на велосипеде");
    }
}

class publictransport : itransportstrategy
{
    public void go()
    {
        System.Console.WriteLine("Поездка на общественном транспорте");
    }
}

class transportservice
{
    itransportstrategy strategy;

    public void setstrategy(itransportstrategy s)
    {
        strategy = s;
    }

    public void start()
    {
        strategy.go();
    }
}

class program
{
    static void Main()
    {
        transportservice t = new transportservice();

        t.setstrategy(new cartransport());
        t.start();

        t.setstrategy(new biketransport());
        t.start();

        t.setstrategy(new publictransport());
        t.start();

        System.Console.ReadLine();
    }
}