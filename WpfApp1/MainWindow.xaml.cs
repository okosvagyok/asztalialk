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
        public void read()
        {
            StreamReader f = new StreamReader("C:\\Users\\kemenes.marton\\Downloads\\Oscar\\Oscar\\oscar.csv");
            f.ReadLine();
            while(!f.EndOfStream)
            {
                string sor = f.ReadLine();
                films.Add(new Films(sor.Split(";")[0], sor.Split(";")[1], int.Parse(sor.Split(";")[2]), int.Parse(sor.Split(";")[3]), int.Parse(sor.Split(";")[4])));
            }
        }
        public void outTitles()
        {
            for (int i = 0; i < films.Count(); i++)
            {
                oscarsFilms.Items.Add(films[i].title);
            }
        }
        private void newFilm_Click(object sender, RoutedEventArgs e)
        {
            if (newTitle.Text == "" || newYear.Text == "" || newNominees.Text == "" || newAwards.Text == "") { MessageBox.Show("Kérlek, tölts ki minden mezőt!"); };
            oscarsFilms.Items.Add(newTitle.Text);
            films.Add(new Films(rnd.Next(1, 10).ToString(), newTitle.Text, int.Parse(newYear.Text), int.Parse(newAwards.Text), int.Parse(newNominees.Text)));
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