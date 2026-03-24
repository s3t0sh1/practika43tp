delegate void downloadhandler(int percent);

class filedownloader
{
    public event downloadhandler downloadprogress;

    public void start()
    {
        for (int i = 0; i <= 100; i += 25)
            if (downloadprogress != null)
                downloadprogress(i);
    }
}

class progressbar
{
    public void show(int percent)
    {
        System.Console.WriteLine("Индикатор: " + percent + "%");
    }
}

class logger
{
    public void write(int percent)
    {
        System.Console.WriteLine("Лог: загружено " + percent + "%");
    }
}

class Program
{
    static void Main()
    {
        filedownloader f = new filedownloader();
        progressbar p = new progressbar();
        logger l = new logger();

        f.downloadprogress += p.show;
        f.downloadprogress += l.write;

        f.start();

        System.Console.ReadLine();
    }
}