using System;
using System.IO;

class FileManager
{
    public void CreateFile(string path, string text)
    {
        File.WriteAllText(path, text);
    }

    public string ReadFile(string path)
    {
        return File.ReadAllText(path);
    }

    public void CopyFile(string source, string dest)
    {
        File.Copy(source, dest, true);
    }

    public void MoveFile(string source, string dest)
    {
        File.Move(source, dest);
    }

    public void DeleteFile(string path)
    {
        File.Delete(path);
    }

    public void RenameFile(string oldPath, string newPath)
    {
        File.Move(oldPath, newPath);
    }
}

class FileInfoProvider
{
    public void ShowInfo(string path)
    {
        if (File.Exists(path))
        {
            FileInfo f = new FileInfo(path);

            Console.WriteLine("Файл: " + f.Name);
            Console.WriteLine("Размер: " + f.Length + " байт");
            Console.WriteLine("Дата создания: " + f.CreationTime);
            Console.WriteLine("Дата изменения: " + f.LastWriteTime);
        }
        else
        {
            Console.WriteLine("Файл не существует");
        }
    }

    public void CompareBySize(string path1, string path2)
    {
        if (File.Exists(path1) && File.Exists(path2))
        {
            long s1 = new FileInfo(path1).Length;
            long s2 = new FileInfo(path2).Length;

            if (s1 > s2)
                Console.WriteLine("Первый файл больше");
            else if (s2 > s1)
                Console.WriteLine("Второй файл больше");
            else
                Console.WriteLine("Файлы одинаковы по размеру");
        }
        else
        {
            Console.WriteLine("Один из файлов не найден");
        }
    }

    public void ShowPermissions(string path)
    {
        if (File.Exists(path))
        {
            FileInfo f = new FileInfo(path);

            Console.WriteLine("Права файла:");
            Console.WriteLine("Чтение: да");
            Console.WriteLine("Запись: " + ((f.Attributes & FileAttributes.ReadOnly) == 0 ? "да" : "нет"));
            Console.WriteLine("Выполнение: зависит от типа файла и ОС");
        }
        else
        {
            Console.WriteLine("Файл не найден");
        }
    }
}

class Program
{
    static void Main()
    {
        FileManager fm = new FileManager();
        FileInfoProvider info = new FileInfoProvider();

        string baseDir = Path.Combine(Directory.GetCurrentDirectory(), "files");
        string newDir = Path.Combine(baseDir, "newfolder");

        Directory.CreateDirectory(baseDir);
        Directory.CreateDirectory(newDir);

        string baseFileName = "petrov.rs";
        string file1 = Path.Combine(baseDir, baseFileName);
        string copyFile = Path.Combine(baseDir, "copy_" + baseFileName);
        string movedFile = Path.Combine(newDir, baseFileName);
        string renamedFile = Path.Combine(newDir, "familiya.io");
        string file2 = Path.Combine(baseDir, "second.ii");

        Console.WriteLine("1. Создание файла, запись, чтение");
        fm.CreateFile(file1, "Это тестовый файл");
        Console.WriteLine(fm.ReadFile(file1));
        Console.WriteLine();

        Console.WriteLine("2. Проверка существования файла перед удалением");
        if (File.Exists(file2))
        {
            fm.DeleteFile(file2);
            Console.WriteLine("Файл second.ii удален");
        }
        else
        {
            Console.WriteLine("Файл second.ii не существует");
        }
        Console.WriteLine();

        Console.WriteLine("3. Информация о файле");
        info.ShowInfo(file1);
        Console.WriteLine();

        Console.WriteLine("4. Копирование файла");
        fm.CopyFile(file1, copyFile);
        Console.WriteLine(File.Exists(copyFile) ? "Копия существует" : "Копия не создана");
        Console.WriteLine();

        Console.WriteLine("5. Перемещение файла в новую директорию");
        if (File.Exists(movedFile))
            File.Delete(movedFile);
        fm.MoveFile(copyFile, movedFile);
        Console.WriteLine(File.Exists(movedFile) ? "Файл перемещен" : "Файл не перемещен");
        Console.WriteLine();

        Console.WriteLine("6. Переименование файла в familiya.io");
        if (File.Exists(renamedFile))
            File.Delete(renamedFile);
        fm.RenameFile(movedFile, renamedFile);
        Console.WriteLine(File.Exists(renamedFile) ? "Файл переименован" : "Переименование не выполнено");
        Console.WriteLine();

        Console.WriteLine("7. Обработка ошибки при удалении несуществующего файла");
        try
        {
            string noFile = Path.Combine(baseDir, "nofile.ii");
            if (!File.Exists(noFile))
                throw new FileNotFoundException("Файл не найден", noFile);

            fm.DeleteFile(noFile);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка: " + e.Message);
        }
        Console.WriteLine();

        Console.WriteLine("8. Сравнение двух файлов по размеру");
        fm.CreateFile(file2, "Еще один файл для сравнения");
        info.CompareBySize(file1, file2);
        Console.WriteLine();

        Console.WriteLine("9. Удаление всех файлов с расширением .ii");
        string[] iiFiles = Directory.GetFiles(baseDir, "*.ii");
        for (int i = 0; i < iiFiles.Length; i++)
        {
            File.Delete(iiFiles[i]);
            Console.WriteLine("Удален: " + Path.GetFileName(iiFiles[i]));
        }
        Console.WriteLine();

        Console.WriteLine("10. Список всех файлов в директории files");
        string[] allFiles = Directory.GetFiles(baseDir);
        for (int i = 0; i < allFiles.Length; i++)
            Console.WriteLine(Path.GetFileName(allFiles[i]));
        Console.WriteLine();

        Console.WriteLine("11. Запрет записи в файл и попытка записать");
        FileInfo rf = new FileInfo(renamedFile);
        rf.Attributes = rf.Attributes | FileAttributes.ReadOnly;

        try
        {
            File.WriteAllText(renamedFile, "Попытка записи");
            Console.WriteLine("Запись выполнена");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ошибка записи: " + e.Message);
        }
        Console.WriteLine();

        Console.WriteLine("12. Проверка доступных прав к файлу");
        info.ShowPermissions(renamedFile);
        Console.WriteLine();

        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}