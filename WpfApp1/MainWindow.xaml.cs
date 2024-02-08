using System.Diagnostics;
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

        int szamCount = 0;
        string muveletEk = "";
        private void szam(object sender, RoutedEventArgs e)
        {
            if (szamCount == 0)
            {
                szamCount++;
                muveletEk += szamCount.ToString();
                kiir.Content += ((Button)sender).Content.ToString();
            }
        }

        private void muvelet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }

        private void egyenlo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0");
        }
    }
}