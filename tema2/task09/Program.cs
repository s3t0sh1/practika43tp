using System.Text;

StringBuilder s = new StringBuilder("привет, меня зовут Рома я учусь в ГКТТиД 43ТП");

Console.WriteLine("до очистки: " + s.ToString());

s.Clear();

Console.WriteLine("после очистки: " + s.ToString());
Console.WriteLine("длина: " + s.Length);