using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using ShopOrdersWpf.Commands;

namespace ShopOrdersWpf
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Order> Orders { get; set; }

        public CreateOrderCommand CreateOrderCmd { get; set; }
        public EditOrderCommand EditOrderCmd { get; set; }
        public DeleteOrderCommand DeleteOrderCmd { get; set; }

        private string SavePath => "orders.json";

        public MainWindow()
        {
            InitializeComponent();

            Orders = new ObservableCollection<Order>();
            LoadOrders();

            CreateOrderCmd = new CreateOrderCommand(this);
            EditOrderCmd = new EditOrderCommand(this);
            DeleteOrderCmd = new DeleteOrderCommand(this);

            DataContext = this;
        }

        private void SaveOrders()
        {
            var json = JsonSerializer.Serialize(Orders);
            File.WriteAllText(SavePath, json);
        }

        private void LoadOrders()
        {
            if (File.Exists(SavePath))
            {
                var json = File.ReadAllText(SavePath);
                var list = JsonSerializer.Deserialize<ObservableCollection<Order>>(json);

                Orders.Clear();
                foreach (var o in list)
                    Orders.Add(o);
            }
            else
            {
                // Первоначальные данные только если файла нет
                Orders.Add(new Order { Product = "Ноутбук", Quantity = 1, Status = "Новый" });
                Orders.Add(new Order { Product = "Телефон", Quantity = 2, Status = "Доставляется" });
                Orders.Add(new Order { Product = "Наушники", Quantity = 3, Status = "Доставлен" });
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            SaveOrders();
        }

        public void CreateOrder()
        {
            Order newOrder = new Order
            {
                Product = "Новый товар",
                Quantity = 1,
                Status = "Новый"
            };

            Orders.Add(newOrder);
        }

        public void EditOrder()
        {
            if (OrdersList.SelectedItem is Order order)
            {
                EditOrderWindow win = new EditOrderWindow(order);
                win.Owner = this;

                if (win.ShowDialog() == true)
                {
                    // объект уже обновлён
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }

        public void DeleteOrder()
        {
            if (OrdersList.SelectedItem is Order order)
            {
                if (MessageBox.Show("Удалить заказ?", "Подтверждение",
                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Orders.Remove(order);
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }
    }
}
