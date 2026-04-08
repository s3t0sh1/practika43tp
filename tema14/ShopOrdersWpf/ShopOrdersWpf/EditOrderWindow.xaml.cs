using System.Windows;

namespace ShopOrdersWpf
{
    public partial class EditOrderWindow : Window
    {
        public Order TempOrder { get; set; }
        private Order OriginalOrder;

        public EditOrderWindow(Order order)
        {
            InitializeComponent();

            // сохраняем оригинал
            OriginalOrder = order;

            // создаём копию
            TempOrder = new Order
            {
                Product = order.Product,
                Quantity = order.Quantity,
                Status = order.Status
            };

            DataContext = TempOrder;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // переносим изменения в оригинал
            OriginalOrder.Product = TempOrder.Product;
            OriginalOrder.Quantity = TempOrder.Quantity;
            OriginalOrder.Status = TempOrder.Status;

            DialogResult = true;
            Close();
        }
    }
}