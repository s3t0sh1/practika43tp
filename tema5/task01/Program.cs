abstract class outputdevice
{
    public string name;
    public outputdevice(string n)
    {
        name = n;
    }
    public abstract void displayinfo();
}
class monitor : outputdevice
{
    public monitor(string n) : base(n) { }

    public override void displayinfo()
    {
        System.Console.WriteLine("монитор: " + name);
    }
}
class printer : outputdevice
{
    public printer(string n) : base(n) { }
    public override void displayinfo()
    {
        System.Console.WriteLine("принтер: " + name);
    }
}
class projector : outputdevice
{
    public projector(string n) : base(n) { }
    public override void displayinfo()
    {
        System.Console.WriteLine("проектор: " + name);
    }
}
class Program
{
    static void Main()
    {
        outputdevice[] a ={
            new monitor("samsung"),
            new printer("HP"),
            new projector("epson")
        };
        for (int i = 0; i < a.Length; i++)
            a[i].displayinfo();
        System.Console.ReadLine();
    }
}