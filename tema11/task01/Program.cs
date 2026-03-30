using System;

namespace FactoryMethodExample
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата наличными: {amount} руб.");
        }
    }

    public class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата картой: {amount} руб.");
        }
    }

    public class CryptoPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата криптовалютой: {amount} руб.");
        }
    }

    public abstract class PaymentFactory
    {
        public abstract IPayment CreatePayment();
    }

    public class CashFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CashPayment();
        }
    }

    public class CardFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CardPayment();
        }
    }

    public class CryptoFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CryptoPayment();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            PaymentFactory factory;

            factory = new CashFactory();
            IPayment cashPayment = factory.CreatePayment();
            cashPayment.Pay(1500);

            factory = new CardFactory();
            IPayment cardPayment = factory.CreatePayment();
            cardPayment.Pay(2300);

            factory = new CryptoFactory();
            IPayment cryptoPayment = factory.CreatePayment();
            cryptoPayment.Pay(5000);
        }
    }
}