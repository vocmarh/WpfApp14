using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Помидоро",
                Price = 126,
                Image = "Pictures/Pomidoro.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Банан",
                Price = 90,
                Image = "Pictures/Banana.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Купальник",
                Price = 8000,
                Image = "Pictures/Swimsuit.jpg",
                Category = Category.Clothes
            });
            products.Add(new Product()
            {
                NameProduct = "Кока-кола",
                Price = 35,
                Image = "Pictures/Coca-cola.jpg",
                Category = Category.Beverages
            });
            IstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                NameProduct = "Стриральная машина",
                Price = 32000,
                Image = "Pictures/Washing machine.jpg",
                Category = Category.Technics
            });
        }
    }
}
