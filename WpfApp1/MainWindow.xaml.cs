using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Gombra kattintottál?", "Gombok", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Helyes válasz", "Gombok", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Nem sikerült", "Gombok", MessageBoxButton.OK, MessageBoxImage.Warning);
                    break;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Elindítottál egy időzítőt", "Gombok", MessageBoxButton.OK, MessageBoxImage.Information);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(9);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Eltelt 9 másodperc", "Gombok", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fájl beolvasása", "Gombok", MessageBoxButton.OK, MessageBoxImage.Information);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == true)
                {
                    string reading = File.ReadAllText(@"C:\Users\kemenes.marton\Desktop\ezegy.txt", Encoding.UTF8);
                    MessageBox.Show(reading, "Gombok", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Width = 200;
        }
    }
};