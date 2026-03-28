using System;
using System.Collections.Generic;

class taskqueuemanager
{
    static taskqueuemanager instance;
    Queue<Action> tasks = new Queue<Action>();

    private taskqueuemanager() { }

    public static taskqueuemanager getinstance()
    {
        if (instance == null)
            instance = new taskqueuemanager();
        return instance;
    }

    public void addtask(Action task)
    {
        tasks.Enqueue(task);
    }

    public void executetasks()
    {
        while (tasks.Count > 0)
        {
            Action t = tasks.Dequeue();
            t();
        }
    }
}

class program
{
    static void Main()
    {
        taskqueuemanager q = taskqueuemanager.getinstance();

        q.addtask(() => System.Console.WriteLine("Задача 1 выполнена"));
        q.addtask(() => System.Console.WriteLine("Задача 2 выполнена"));
        q.addtask(() => System.Console.WriteLine("Задача 3 выполнена"));

        q.executetasks();

        System.Console.ReadLine();
    }
}