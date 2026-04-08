using System;
using System.Windows.Input;

namespace ShopOrdersWpf
{
    public class AddOrderCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter is MainWindow window)
                window.CreateOrder();
        }
    }
}