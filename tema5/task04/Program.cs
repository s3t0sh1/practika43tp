interface icooler
{
    void adjusttemperature(int degrees);
}
interface iheater
{
    void adjusttemperature(int degrees);
}
class climatecontrol : icooler, iheater
{
    void icooler.adjusttemperature(int degrees)
    {
        System.Console.WriteLine("Охлаждение на " + degrees + " градусов");
    }
    void iheater.adjusttemperature(int degrees)
    {
        System.Console.WriteLine("Нагрев на " + degrees + " градусов");
    }
}
class Program
{
    static void Main()
    {
        climatecontrol a = new climatecontrol();
        icooler c = a;
        iheater h = a;
        c.adjusttemperature(5);
        h.adjusttemperature(7);
        System.Console.ReadLine();
    }
}