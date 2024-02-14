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
        List<hajo>hajok = new List<hajo>();
        public MainWindow()
        {
            InitializeComponent();
            //beolvasás
        }
        class hajo()
        {
            public int sorszam;
            public string nev;
            public string tipus;
            public int maxutasszam;
            public int berletdij;

            public hajo(int sorszam, string nev, string tipus, int maxutasszam, int berletdij)
            {
                this.sorszam = sorszam;
                this.nev = nev;
                this.tipus = tipus;
                this.maxutasszam = maxutasszam;
                this.berletdij = berletdij;
            }
        }
        void beolvasas()
        {
            StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\Sétahajó_WPF\Sétahajó_WPF\hajo-1.txt");
            f.ReadLine();
            while (!f.EndOfStream)
            {
                string[] darabolt = f.ReadLine().Split('\t');
                hajok.Add(new hajo(int.Parse(darabolt[0]), darabolt[1], darabolt[2], int.Parse(darabolt[3]), int.Parse(darabolt[4])));
            }
            f.Close();

        }

        private void Keres()
        {

        }
    }
}