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
            read();
            outTitles();
        }
        Random rnd = new Random();
        List<Films> films = new List<Films>();
        List<string> titles = new List<string>();
        public void read()
        {
            StreamReader f = new StreamReader("C:\\Users\\kemenes.marton\\Downloads\\Oscar\\Oscar\\oscar.csv");
            f.ReadLine();
            while(!f.EndOfStream)
            {
                string sor = f.ReadLine();
                films.Add(new Films(sor.Split(";")[0], sor.Split(";")[1], int.Parse(sor.Split(";")[2]), int.Parse(sor.Split(";")[3]), int.Parse(sor.Split(";")[4])));
            }
            for(int i = 0; i < films.Count; i++)
            {
                titles.Add(films[i].title);
            }
            titles.Sort();
        }
        public void outTitles()
        {
            for (int i = 0; i < films.Count(); i++)
            {
                oscarsFilms.Items.Add(titles[i]);
            }
        }
        private void newFilm_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (newTitle.Text.Length == 0 || newYear.Text.Length == 0 || newNominees.Text.Length == 0 || newAwards.Text.Length == 0)
            {
                MessageBox.Show("Kérlek, tölts ki minden mezőt!");
            }
            else if (!int.TryParse(newNominees.Text, out n) || !int.TryParse(newAwards.Text, out n) || !int.TryParse(newYear.Text, out n))
            {
                MessageBox.Show("Kérlek, számot adj meg!");
            }
            else if (int.TryParse(newNominees.Text, out n) || int.TryParse(newAwards.Text, out n))
            {
                int nominees = int.Parse(newNominees.Text);
                int awards = int.Parse(newAwards.Text);
                if (nominees < awards)
                {
                    MessageBox.Show("A film nem kaphatott több díjat, mint jelölést!");
                }
            }
            else //if (int.TryParse(newNominees.Text, out n) || int.TryParse(newAwards.Text, out n))
            {
                oscarsFilms.Items.Add(newTitle.Text);
                films.Add(new Films(rnd.Next(1, 10).ToString(), newTitle.Text, int.Parse(newYear.Text), int.Parse(newAwards.Text), int.Parse(newNominees.Text)));
                MessageBox.Show("Sikeresen hozzáadtad a filmet a listához");
            }
        }
        private void mostAwards_Click(object sender, RoutedEventArgs e)
        {
            int mostOscars = 0;
            string mostOscarsTitle = "";
            for (int i = 0; i < films.Count(); i++)
            {
                if (films[i].awards > mostOscars)
                {
                    mostOscars = films[i].awards;
                    mostOscarsTitle = films[i].title;
                }
            }
            mostAwardsWon.Text = mostOscarsTitle;
        }
        private void search_Click(object sender, RoutedEventArgs e)
        {
            if (searchFilms.Text.Length == 0)
            {
                MessageBox.Show("Kérlek, írd be egy film címét!");
            }
            else
            {
                    for (int i = 0; i < films.Count(); i++)
                    {
                        StringComparison cIgnore = StringComparison.OrdinalIgnoreCase;
                        if (titles[i].Contains(searchFilms.Text, cIgnore))
                        {
                            finds.Text = "A keresett film címe: ";
                            finds.Text += titles[i];
                        }
                    }
                    if (finds.Text.Length == 0)
                    {
                        MessageBox.Show("Sajnos nincs ilyen film a listában");
                    }
            }
        }
        private void toList_Click(object sender, RoutedEventArgs e)
        {
            findsFilms.Items.Clear();
            if (findsToList.Text.Length == 0)
            {
                MessageBox.Show("Kérlek, írd be egy film címét!");
            }
            else
            {
                for (int i = 0; i < films.Count(); i++)
                {
                    StringComparison cIgnore = StringComparison.OrdinalIgnoreCase;
                    if (titles[i].Contains(findsToList.Text, cIgnore))
                    {
                        findsFilms.Items.Add(titles[i]);
                    }
                }
                if (findsFilms.Items.Count == 0)
                {
                    MessageBox.Show("Sajnos nincs ilyen film a listában");
                }
            }
        }
        public class Films
        {
            public string id;
            public string title;
            public int year;
            public int awards;
            public int nominees;

            public Films(string id, string title, int year, int awards, int nominees)
            {
                this.id = id;
                this.title = title;
                this.year = year;
                this.awards = awards;
                this.nominees = nominees;
            }
        }
    }
};