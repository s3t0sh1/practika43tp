class educationinstitution
{
    public string name;
    public educationinstitution(string n)
    {
        name = n;
    }
}
interface ihasonlinecourses
{
    void online();
}
interface ihascampus
{
    void campus();
}
class onlineschool : educationinstitution, ihasonlinecourses
{
    public onlineschool(string n) : base(n) { }
    public void online()
    {
        System.Console.WriteLine(name + " имеет онлайн-курсы");
    }
}
class university : educationinstitution, ihascampus
{
    public university(string n) : base(n) { }

    public void campus()
    {
        System.Console.WriteLine(name + " имеет кампус");
    }
}
class Program
{
    static void Main()
    {
        educationinstitution[] a ={
            new onlineschool("Skillbox"),
            new university("ГРГУ"),
            new onlineschool("Яндекс Практикум"),
            new university("БГУ")
        };

        System.Console.WriteLine("Онлайн-школы:");
        for (int i = 0; i < a.Length; i++)
            if (a[i] is ihasonlinecourses)
                System.Console.WriteLine(a[i].name);
        System.Console.ReadLine();
    }
}