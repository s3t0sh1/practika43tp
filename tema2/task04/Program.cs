int[,] a = new int[18, 36];
Random r = new Random();

for (int i = 0; i < 18; i++)
{
    for (int j = 0; j < 36; j++)
        a[i, j] = r.Next(0, 2);
}

for (int i = 0; i < 18; i++)
{
    bool f = false;

    for (int j = 0; j < 36; j++)
    {
        if (a[i, j] == 0)
        {
            f = true;
            break;
        }
    }

    if (f)
        Console.WriteLine("в вагоне " + (i + 1) + " есть свободные места");
    else
        Console.WriteLine("в вагоне " + (i + 1) + " свободных мест нет");
}