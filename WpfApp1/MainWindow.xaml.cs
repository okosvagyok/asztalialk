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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
        }

        List<Szamok> szamok = new List<Szamok> { };
        public void Beolvas()
        {
            StreamReader f = new StreamReader(@"C:\Users\kemenes.marton\Downloads\EgyszámjátékGUI\EgyszámjátékGUI\egyszamjatek1.txt");
            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                szamok.Add(new Szamok(sor.Split(" ")[0], int.Parse(sor.Split(" ")[1]), int.Parse(sor.Split(" ")[2]), int.Parse(sor.Split(" ")[3]), int.Parse(sor.Split(" ")[4])));
            }
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (jatekosnev.Text.Length > 0 || jatekostipp.Text.Length > 0)
            {
                MessageBox.Show("Egyik mező sem maradhat üresen!", "Hiba!");
            }
            for (int i = 0; i < szamok.Count(); i++)
            {
                if (jatekosnev.Text == szamok[i].nev)
                {
                    MessageBox.Show("Van már ilyen nevű játékos!", "Hiba!");
                }
                if (jatekostipp.Text.Length != 7)
                {
                    MessageBox.Show("A tippek száma nem megfelelő!", "Hiba!");
                }
            }
            StreamWriter w = new StreamWriter(@"egyszamjatek2.txt");
            for (int i = 0; i < szamok.Count(); i++)
            {
                w.WriteLine(szamok[i].nev + " " + szamok[i].szam + " " + szamok[i].szam1 + " " + szamok[i].szam2 + " " + szamok[i].szam3);
            }
            szamok.Add(new Szamok(jatekosnev.Text, int.Parse(jatekostipp.Text.Split(" ")[0]), int.Parse(jatekostipp.Text.Split(" ")[1]), int.Parse(jatekostipp.Text.Split(" ")[2]), int.Parse(jatekostipp.Text.Split(" ")[3])));
            MessageBox.Show("Az állomány bővítése sikeres volt!", "Üzenet");
            jatekosnev.Text = "";
            jatekostipp.Text = "";
        }
    }
    public class Szamok()
    {
        public string nev;
        public int szam;
        public int szam1;
        public int szam2;
        public int szam3;

        public Szamok(string nev, int szam, int szam1, int szam2, int szam3)
        {
            this.nev = nev;
            this.szam = szam;
            this.szam1 = szam1;
            this.szam2 = szam2;
            this.szam3 = szam3;
        }
    }
};