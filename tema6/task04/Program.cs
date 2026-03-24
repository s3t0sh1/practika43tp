class messageeventargs : System.EventArgs
{
    public string text;

    public messageeventargs(string t)
    {
        text = t;
    }
}

class chatapplication
{
    public event System.EventHandler<messageeventargs> messagereceived;

    public void receivemessage(string text)
    {
        if (messagereceived != null)
            messagereceived(this, new messageeventargs(text));
    }
}

class desktopnotification
{
    public void show(object sender, messageeventargs e)
    {
        System.Console.WriteLine("Уведомление: " + e.text);
    }
}

class soundalert
{
    public void play(object sender, messageeventargs e)
    {
        System.Console.WriteLine("Звук: новое сообщение");
    }
}

class messagenotifier
{
    public messagenotifier(chatapplication c, desktopnotification d, soundalert s)
    {
        c.messagereceived += d.show;
        c.messagereceived += s.play;
    }
}

class Program
{
    static void Main()
    {
        chatapplication c = new chatapplication();
        desktopnotification d = new desktopnotification();
        soundalert s = new soundalert();

        messagenotifier m = new messagenotifier(c, d, s);

        c.receivemessage("Привет");

        System.Console.ReadLine();
    }
}