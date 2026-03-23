class citizen
{
    public string name;

    public citizen(string n)
    {
        name = n;
    }
}

class infrastructure
{
    public int schools;
    public int hospitals;

    public infrastructure(int s, int h)
    {
        schools = s;
        hospitals = h;
    }
}

class country
{
    public string name;

    public country(string n)
    {
        name = n;
    }
}

class city
{
    public string name;
    public citizen[] citizens;
    public infrastructure infra;
    public country country;

    public city(string n, citizen[] c, country country1, int s, int h)
    {
        name = n;
        citizens = c;
        country = country1;
        infra = new infrastructure(s, h);
    }

    public void showpopulation()
    {
        System.Console.WriteLine(name + ": " + citizens.Length + " жителей");
    }
}

class Program
{
    static void Main()
    {
        country c = new country("Беларусь");

        city[] a ={
            new city("Минск",new citizen[]{new citizen("А"),new citizen("Б"),new citizen("В")},c,10,5),
            new city("Гродно",new citizen[]{new citizen("Г"),new citizen("Д")},c,7,3),
            new city("Брест",new citizen[]{new citizen("Е"),new citizen("Ж"),new citizen("З"),new citizen("И")},c,8,4)
        };

        for (int i = 0; i < a.Length; i++)
            a[i].showpopulation();

        System.Console.ReadLine();
    }
}