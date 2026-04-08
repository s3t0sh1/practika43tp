using System;
using System.Windows.Input;

namespace ShopOrdersWpf.Commands
{
    public class DeleteOrderCommand : ICommand
    {
        private readonly MainWindow window;

        public DeleteOrderCommand(MainWindow w)
        {
            window = w;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            window.DeleteOrder();
        }
    }
}