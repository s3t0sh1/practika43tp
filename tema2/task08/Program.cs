Console.Write("введите строку: ");
string s = Console.ReadLine();

Console.Write("введите сдвиг: ");
int k = int.Parse(Console.ReadLine());

string res = "";

for (int i = 0; i < s.Length; i++)
{
    char c = s[i];

    if (c >= 'a' && c <= 'z')
    {
        c = (char)(c - k);
        if (c < 'a')
            c = (char)(c + 26);
    }
    else if (c >= 'A' && c <= 'Z')
    {
        c = (char)(c - k);
        if (c < 'A')
            c = (char)(c + 26);
    }

    res += c;
}

Console.WriteLine("расшифрованная строка: " + res);