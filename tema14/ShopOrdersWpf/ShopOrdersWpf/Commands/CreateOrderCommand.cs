using System;
using System.Windows.Input;

namespace ShopOrdersWpf.Commands
{
    public class CreateOrderCommand : ICommand
    {
        private readonly MainWindow window;

        public CreateOrderCommand(MainWindow w)
        {
            window = w;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            window.CreateOrder();
        }
    }
}