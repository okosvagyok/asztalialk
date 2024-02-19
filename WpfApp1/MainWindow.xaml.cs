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
        public List<Sutemeny> sutemenyek;

        public MainWindow()
        {
            sutemenyek = new List<Sutemeny>();
            InitializeComponent();
            Beolvas();
            BetoltRandom();
            LegolcsobbEsLegdragabb();
            DijazottakOsszesen();
        }

        private void Beolvas()
        {
            // Süni;vegyes;false;300;db
            foreach (string sor in File.ReadAllLines(@"C:\Users\kemenes.marton\Downloads\Cukrászda_WPF\Cukrászda_WPF\cuki.txt"))
            {
                string[] adatok = sor.Split(';');
                sutemenyek.Add(new Sutemeny(adatok[0], adatok[1], Convert.ToBoolean(adatok[2].ToLower()),
                    int.Parse(adatok[3]), adatok[4]));
            }
        }

        private void BetoltRandom()
        {
            int sorszam = new Random().Next(1, sutemenyek.Count);
            Sutemeny sutemeny = sutemenyek[sorszam];
            ajanlat.Content = $"Mai ajánlatunk: {sutemeny.nev}";
        }

        private void LegolcsobbEsLegdragabb()
        {
            Sutemeny max = sutemenyek[0];
            Sutemeny min = sutemenyek[0];
            for (int i = 1; i < sutemenyek.Count; i++)
            {
                if (sutemenyek[i].ar > max.ar)
                {
                    max = sutemenyek[i];
                }
                if (sutemenyek[i].ar < min.ar)
                {
                    min = sutemenyek[i];
                }
            }
            lblmax.Content = max.nev;
            lblmin.Content = min.nev;

        }
        private void DijazottakOsszesen()
        {
            int dijazottakszama = 0;
            for (int i = 0; i < sutemenyek.Count; i++)
            {
                if (sutemenyek[i].dijazottE == true)
                {
                    dijazottakszama++;
                }
            }
            dijazottossz.Content = $"{dijazottakszama} féle díjnyertes édességből választhat.";
        }
    }



    public class Sutemeny
    {
        public string nev;
        public string tipus;
        public bool dijazottE;
        public int ar;
        public string egyseg;

        public Sutemeny(string nev, string tipus, bool dijazottE, int ar, string egyseg)
        {
            this.nev = nev;
            this.tipus = tipus;
            this.dijazottE = dijazottE;
            this.ar = ar;
            this.egyseg = egyseg;
        }
    }
};