class orderlimitexceededexception : System.Exception
{
    public orderlimitexceededexception() { }
    public orderlimitexceededexception(string m) : base(m) { }
}

class ordermanager
{
    public void placeorder(int n)
    {
        if (n > 100)
            throw new orderlimitexceededexception("Превышен лимит заказов");

        System.Console.WriteLine("Заказ принят: " + n);
    }
}

class program
{
    static void Main()
    {
        ordermanager o = new ordermanager();

        try
        {
            o.placeorder(150);
        }
        catch (orderlimitexceededexception e)
        {
            System.Console.WriteLine("Ошибка: " + e.Message);
        }

        System.Console.ReadLine();
    }
}