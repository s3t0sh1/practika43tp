using System;

namespace CommandExample
{
    public interface ICommand
    {
        void Execute();
    }
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Свет включён.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Свет выключен.");
        }
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }

    public class RemoteControl
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            if (command != null)
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("Команда не установлена.");
            }
        }
    }

    public class OrderSystem
    {
        public void PlaceOrder(string orderName)
        {
            Console.WriteLine($"Заказ \"{orderName}\" оформлен.");
        }

        public void CancelOrder(string orderName)
        {
            Console.WriteLine($"Заказ \"{orderName}\" отменён.");
        }
    }

    public class PlaceOrderCommand : ICommand
    {
        private readonly OrderSystem orderSystem;
        private readonly string orderName;

        public PlaceOrderCommand(OrderSystem orderSystem, string orderName)
        {
            this.orderSystem = orderSystem;
            this.orderName = orderName;
        }

        public void Execute()
        {
            orderSystem.PlaceOrder(orderName);
        }
    }

    public class CancelOrderCommand : ICommand
    {
        private readonly OrderSystem orderSystem;
        private readonly string orderName;

        public CancelOrderCommand(OrderSystem orderSystem, string orderName)
        {
            this.orderSystem = orderSystem;
            this.orderName = orderName;
        }

        public void Execute()
        {
            orderSystem.CancelOrder(orderName);
        }
    }

    public class OrderInvoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Run()
        {
            if (command != null)
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("Команда не установлена.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Умный дом: управление освещением ===");

            Light light = new Light();
            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(lightOn);
            remote.PressButton();

            remote.SetCommand(lightOff);
            remote.PressButton();

            Console.WriteLine();
            Console.WriteLine("=== Ресторан: оформление заказа ===");

            OrderSystem orderSystem = new OrderSystem();

            ICommand placeOrder = new PlaceOrderCommand(orderSystem, "Пицца Маргарита");
            ICommand cancelOrder = new CancelOrderCommand(orderSystem, "Пицца Маргарита");

            OrderInvoker invoker = new OrderInvoker();

            invoker.SetCommand(placeOrder);
            invoker.Run();

            invoker.SetCommand(cancelOrder);
            invoker.Run();
        }
    }
}