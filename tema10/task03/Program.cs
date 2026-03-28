using System;
using System.Collections.Generic;

interface isubscriber
{
    void update(string article);
}

class emailsubscriber : isubscriber
{
    public void update(string article)
    {
        System.Console.WriteLine("Email: новая статья - " + article);
    }
}

class rsssubscriber : isubscriber
{
    public void update(string article)
    {
        System.Console.WriteLine("RSS: новая статья - " + article);
    }
}

class blog
{
    List<isubscriber> subs = new List<isubscriber>();

    public void subscribe(isubscriber s)
    {
        subs.Add(s);
    }

    public void publisharticle(string article)
    {
        for (int i = 0; i < subs.Count; i++)
            subs[i].update(article);
    }
}

class program
{
    static void Main()
    {
        blog b = new blog();

        emailsubscriber e = new emailsubscriber();
        rsssubscriber r = new rsssubscriber();

        b.subscribe(e);
        b.subscribe(r);

        b.publisharticle("Новая статья по C#");

        System.Console.ReadLine();
    }
}