abstract class bankaccount
{
    public double balance;
    public bankaccount(double b)
    {
        balance = b;
    }
    public abstract double calculateinterest();
    public virtual void displaybalance()
    {
        System.Console.WriteLine("Баланс: " + balance);
    }
}

class savingsaccount : bankaccount
{
    public savingsaccount(double b) : base(b) { }

    public override double calculateinterest()
    {
        return balance * 0.05;
    }

    public override void displaybalance()
    {
        System.Console.WriteLine("Сберегательный счет. Баланс: " + balance);
    }
}
class currentaccount : bankaccount
{
    public currentaccount(double b) : base(b) { }
    public override double calculateinterest()
    {
        return balance * 0.02;
    }
    public override void displaybalance()
    {
        System.Console.WriteLine("Текущий счет. Баланс: " + balance);
    }
}
class program
{
    static void Main()
    {
        savingsaccount a = new savingsaccount(10000);
        currentaccount b = new currentaccount(8000);
        a.displaybalance();
        System.Console.WriteLine("Проценты: " + a.calculateinterest());
        b.displaybalance();
        System.Console.WriteLine("Проценты: " + b.calculateinterest());
        System.Console.ReadLine();
    }
}