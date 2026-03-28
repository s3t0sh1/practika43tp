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

class ClientFileReader
{
    string path = "file.data";

    public List<Client> ReadClients()
    {
        List<Client> clients = new List<Client>();

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] p = lines[i].Split(';');

                if (p.Length == 2)
                {
                    string name = p[0];
                    double balance = double.Parse(p[1]);
                    clients.Add(new Client(name, balance));
                }
            }
        }

        return clients;
    }
}

class ClientProcessor
{
    public List<Client> FindDebtors(List<Client> clients)
    {
        List<Client> debtors = new List<Client>();

        for (int i = 0; i < clients.Count; i++)
            if (clients[i].Balance < 0)
                debtors.Add(clients[i]);

        return debtors;
    }
}

class Program
{
    static void Main()
    {
        ClientFileReader r = new ClientFileReader();
        ClientProcessor p = new ClientProcessor();

        List<Client> clients = r.ReadClients();
        List<Client> debtors = p.FindDebtors(clients);

        Console.WriteLine("Должники:");

        for (int i = 0; i < debtors.Count; i++)
            Console.WriteLine(debtors[i].Name + " " + debtors[i].Balance);

        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}