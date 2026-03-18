Console.Write("введите строку: ");
string s = Console.ReadLine();

Console.Write("введите префикс: ");
string p = Console.ReadLine();

if (s.StartsWith(p))
    Console.WriteLine("строка начинается с этого префикса");
else
    Console.WriteLine("строка не начинается с этого префикса");