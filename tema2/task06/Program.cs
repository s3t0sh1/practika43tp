Console.Write("введите строку: ");
string s = Console.ReadLine();

bool big = false;
bool small = false;

for (int i = 0; i < s.Length; i++)
{
    if (char.IsLetter(s[i]))
    {
        if (char.IsUpper(s[i]))
            big = true;

        if (char.IsLower(s[i]))
            small = true;
    }
}

if (big && small)
    Console.WriteLine("строка содержит буквы разных регистров");
else
    Console.WriteLine("строка содержит буквы одного регистра");