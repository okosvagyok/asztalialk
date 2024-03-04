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
        /*
        private void jatekosKoValaszt_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("C:/Users/kemenes.marton/Downloads/kopapirollo/kopapirollo/kő.jpg", UriKind.Relative);
            jatekosValasztasa.Source = new BitmapImage(resourceUri);
        }
        */
    }
};