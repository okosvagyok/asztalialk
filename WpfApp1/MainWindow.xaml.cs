using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string pizza = "";
        public string topping1 = "";
        public string topping2 = "";
        public string topping3 = "";
        public int margheritaPrice = 3199;
        public int romanaPrice = 3499;
        public int napoletanaPrice = 3499;
        public int cheesePrice = 400;
        public int hamPrice = 300;
        public int baconPrice = 800;
        public int pizzaPrice = 0;
        public int toppingPrice = 0;
        public string toppings = "";
        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            pizzaPrice = 0;
            toppingPrice = 0;
            toppings = "";
            topping1 = "";
            topping2 = "";
            topping3 = "";
            if (margherita.IsChecked == true)
            {
                pizza = "Margherita";
                pizzaPrice += margheritaPrice;
                if (extraCheese.IsChecked == true)
                {
                    topping1 = "sajt";
                    toppingPrice += cheesePrice;
                }
                if (extraHam.IsChecked == true)
                {
                    topping2 = "sonka";
                    toppingPrice += hamPrice;
                }
                if (extraBacon.IsChecked == true)
                {
                    topping3 = "bacon";
                    toppingPrice += baconPrice;
                }
            }
            else if (romana.IsChecked == true)
            {
                pizza = "Romana";
                pizzaPrice += romanaPrice;
                if (extraCheese.IsChecked == true)
                {
                    topping1 = "sajt";
                    toppingPrice += cheesePrice;
                }
                if (extraHam.IsChecked == true)
                {
                    topping2 = "sonka";
                    toppingPrice += hamPrice;
                }
                if (extraBacon.IsChecked == true)
                {
                    topping3 = "bacon";
                    toppingPrice += baconPrice;
                }
            }
            else if (napoletana.IsChecked == true)
            {
                pizza = "Napoletana";
                pizzaPrice += napoletanaPrice;
                if (extraCheese.IsChecked == true)
                {
                    topping1 = "sajt";
                    toppingPrice += cheesePrice;
                }
                if (extraHam.IsChecked == true)
                {
                    topping2 = "sonka";
                    toppingPrice += hamPrice;
                }
                if (extraBacon.IsChecked == true)
                {
                    topping3 = "bacon";
                    toppingPrice += baconPrice;
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy pizzát!");
            }
            if (deliveryName.Text == "" || deliveryPhone.Text == "" || deliveryAdress.Text == "")
            {
                MessageBox.Show("Kérlek, add meg az adataidat.");
            }
            else
            {
                if (topping1 == "")
                {
                    toppings = $"{topping2}, {topping3}";
                }else if (topping2 == "")
                {
                    toppings = $"{topping1}, {topping3}";
                }else if (topping3 == "")
                {
                    toppings = $"{topping1}, {topping2}";
                }
                else
                {
                    toppings = $"{topping1}, {topping2}, {topping3}";
                }
                deliveryInfos.Content = $"Sikeresen megrendelted a {pizza} pizzádat. Extra feltétek: {toppings}.\nA végösszeg: {pizzaPrice+toppingPrice} Ft.";
            }
        }
    }
};