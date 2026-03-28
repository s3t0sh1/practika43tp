using System;
using System.IO;

class FileWatcher
{
    FileSystemWatcher w;

    public FileWatcher(string path)
    {
        w = new FileSystemWatcher(path, "*.config");

        w.Created += OnCreated;
        w.Deleted += OnDeleted;
        w.Changed += OnChanged;
        w.Renamed += OnRenamed;

        w.EnableRaisingEvents = true;
    }

    void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine("Создан файл: " + e.Name);
    }

    void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine("Удален файл: " + e.Name);
    }

    void OnChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine("Конфигурация изменена!");
    }

    void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine("Файл переименован: " + e.OldName + " -> " + e.Name);
    }
}

class Program
{
    static void Main()
    {
        string path = Directory.GetCurrentDirectory();

        FileWatcher f = new FileWatcher(path);

        Console.WriteLine("Отслеживание .config файлов в папке:");
        Console.WriteLine(path);
        Console.WriteLine("Измените, создайте, удалите или переименуйте .config файл");
        Console.WriteLine("Нажмите Enter для выхода...");

        Console.ReadLine();
    }
}