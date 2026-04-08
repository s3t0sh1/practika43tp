using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ShopOrdersWpf
{
    public class Order : INotifyPropertyChanged
    {
        private string product;
        private int quantity;
        private string status;

        public string Product
        {
            get => product;
            set
            {
                product = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return $"{Product} — {Quantity} шт. — {Status}";
        }
    }
}