using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Policy;
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
using System.Windows.Threading;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void printText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            if (lbi != null)
            {
                if (lbi.Content.ToString() == "1")
                {
                    tb.Text = "Egy, megérett a meggy.";
                }
            }
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            lb.Items.Clear();
            tbx.Text = "Lista kiürítve!";
            tb.Text = "";
            btn.Visibility = Visibility.Collapsed;
        }
        private void rebtn_Click(object sender, RoutedEventArgs e)
        {
            if (lb.Items.Count == 0)
            {
                lb.Items.Insert(0, "1");
                lb.Items.Insert(1, "2");
                lb.Items.Insert(2, "3");
                lb.Items.Insert(3, "4");
                lb.Items.Insert(4, "5");
                lb.FontSize = 30;
                lb.HorizontalAlignment = HorizontalAlignment.Center;
            }
            tb.Text = "";
            tbx.Text = "Válassz egy számot";
            btn.Visibility = Visibility.Visible;
        }
    }
};