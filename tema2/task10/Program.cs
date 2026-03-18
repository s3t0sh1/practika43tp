using System.Text.RegularExpressions;

Console.Write("введите строку: ");
string s = Console.ReadLine();

string p = @"(\+375|80)\d{9}";
MatchCollection m = Regex.Matches(s, p, RegexOptions.IgnorePatternWhitespace);

if (m.Count == 0)
{
    Console.WriteLine("номера не найдены");
}
else
{
    Console.WriteLine("найденные номера:");
    for (int i = 0; i < m.Count; i++)
        Console.WriteLine(m[i].Value);
}