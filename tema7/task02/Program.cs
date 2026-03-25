class mathexception : System.Exception
{
    public mathexception(string m, System.Exception i) : base(m, i) { }
}

class mathoperations
{
    public int divide(int a, int b)
    {
        if (b == 0)
            throw new System.DivideByZeroException("Деление на 0");
        return a / b;
    }
}

class calculationmanager
{
    public int calculate(int a, int b)
    {
        try
        {
            mathoperations m = new mathoperations();
            return m.divide(a, b);
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine("Лог: " + e.Message);
            System.Console.WriteLine("Стек: " + e.StackTrace);

            throw new mathexception("Ошибка вычисления", e);
        }
    }
}

class program
{
    static void Main()
    {
        calculationmanager c = new calculationmanager();

        try
        {
            c.calculate(10, 0);
        }
        catch (mathexception e)
        {
            System.Console.WriteLine("Обработано: " + e.Message);
            System.Console.WriteLine("Внутренняя ошибка: " + e.InnerException.Message);
        }

        System.Console.ReadLine();
    }
}