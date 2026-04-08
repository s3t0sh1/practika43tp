using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Text.Json;

namespace ShopOrdersWpf
{
    public partial class MainWindow : Window
    
    {
        public AddOrderCommand AddOrderCmd { get; set; }
        public EditOrderCommand EditOrderCmd { get; set; }
        public DeleteOrderCommand DeleteOrderCmd { get; set; }

        public ObservableCollection<Order> Orders { get; set; }

        public MainWindow()
        {
            
            InitializeComponent();
            AddOrderCmd = new AddOrderCommand();
            EditOrderCmd = new EditOrderCommand();
            DeleteOrderCmd = new DeleteOrderCommand();
            LoadOrders();
            DataContext = this;
        }
        
        public void CreateOrder()
        {
            int newId = Orders.Any() ? Orders.Max(o => o.Id) + 1 : 1;

            Orders.Add(new Order
            {
                Id = newId,
                Client = "Новый клиент",
                Status = "Новый",
                Amount = 0m
            });
            SaveOrders();
        }

        public void EditOrder()
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                order.Client += " (ред.)";
                OrdersGrid.Items.Refresh();
                SaveOrders();
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }

        public void DeleteOrderWithConfirm()
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                if (MessageBox.Show("Удалить заказ?", "Подтверждение",
                        MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Orders.Remove(order);
                    SaveOrders();
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ.");
            }
        }

        private void StatusFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersGrid == null || StatusFilter == null || Orders == null)
                return; 

            if (StatusFilter.SelectedItem is ComboBoxItem item)
            {
                string status = item.Content.ToString();

                if (status == "Все")
                    OrdersGrid.ItemsSource = Orders;
                else
                    OrdersGrid.ItemsSource = Orders.Where(o => o.Status == status).ToList();
            }
        }
        private string FilePath => "orders.json";

        private void SaveOrders()
        {
            var json = JsonSerializer.Serialize(Orders);
            File.WriteAllText(FilePath, json);
        }

        private void LoadOrders()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var loaded = JsonSerializer.Deserialize<ObservableCollection<Order>>(json);

                if (loaded != null)
                    Orders = loaded;
            }
            else
            {
                Orders = new ObservableCollection<Order>();
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveOrders();
        }


        private void SetStatusNew_Click(object sender, RoutedEventArgs e) => SetStatus("Новый");
        private void SetStatusProcessing_Click(object sender, RoutedEventArgs e) => SetStatus("В обработке");
        private void SetStatusDone_Click(object sender, RoutedEventArgs e) => SetStatus("Выполнен");

        private void SetStatus(string status)
        {
            if (OrdersGrid.SelectedItem is Order order)
            {
                order.Status = status;
                OrdersGrid.Items.Refresh();
            }
        }
    }
}

