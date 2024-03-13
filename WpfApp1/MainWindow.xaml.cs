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
        Random rnd = new Random();
        List<int> aHalmaz = new List<int>();
        List<int> bHalmaz = new List<int>();
        private void eloallito(object sender, RoutedEventArgs e)
        {
            aHalmaz.Clear();
            bHalmaz.Clear();
            Ahalmaz.Items.Clear();
            Bhalmaz.Items.Clear();
            AuB.Items.Clear();
            AminuszB.Items.Clear();
            BminuszA.Items.Clear();
            if (aHalmazSzama.Text == "" || bHalmazSzama.Text == "") { MessageBox.Show("Írj be mindkét halmaznak elemszámot!"); };
            for (int i = 0; i < int.Parse(aHalmazSzama.Text); i++)
            {
                int szam = rnd.Next(1, 51);
                aHalmaz.Add(szam);
                Ahalmaz.Items.Add(szam);
            }
            for (int i = 0; i < int.Parse(bHalmazSzama.Text); i++)
            {
                int szam = rnd.Next(1, 51);
                bHalmaz.Add(szam);
                Bhalmaz.Items.Add(szam);
            }
            List<int> kozosek = aHalmaz.Intersect(bHalmaz).ToList();
            for (int i = 0; i < kozosek.Count(); i++)
            {
                AuB.Items.Add(kozosek[i]);
                if (!AuB.Items.Contains(aHalmaz[i]))
                {
                    AuB.Items.Add(aHalmaz[i]);
                }else if (!AuB.Items.Contains(bHalmaz[i]))
                {
                    AuB.Items.Add(bHalmaz[i]);
                }
                AmB.Items.Add(kozosek[i]);
            }
            for (int i = 0; i < aHalmaz.Count(); i++)
            {
                AminuszB.Items.Add(aHalmaz[i]);
            }
            for (int i = 0; i < bHalmaz.Count(); i++)
            {
                BminuszA.Items.Add(bHalmaz[i]);
            }
        }
    }
};