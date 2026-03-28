using System;
using System.Collections.Generic;
using System.IO;

class Client
{
    public string Name;
    public double Balance;

    public Client(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }
}

class ClientFileWriter
{
    string path = "file.data";

    public void OverwriteClients(List<Client> clients)
    {
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < clients.Count; i++)
                sw.WriteLine(clients[i].Name + ";" + clients[i].Balance);
        }
    }
}

class Program
{
    static void Main()
    {
        List<Client> clients = new List<Client>();
        clients.Add(new Client("Иван", 1500));
        clients.Add(new Client("Анна", -200));
        clients.Add(new Client("Олег", 300));

        ClientFileWriter w = new ClientFileWriter();
        w.OverwriteClients(clients);

        Console.WriteLine("Данные записаны в file.data");

        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}