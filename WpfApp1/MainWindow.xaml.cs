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
            randomSzamok();
        }
        Random rnd = new Random();
        List<int> szamok = new List<int>();
        List<int> szamokR = new List<int>();
        private void randomSzamok()
        {
            for (int i = 0; i < 6; i++)
            {
                szamokR.Add(0);
            }
            for (int i = 0; i < 6; i++)
            {
                int szam = rnd.Next(1, 101);
                szamok.Add(szam);
            }
            listItem1.Content = szamok[0];
            listItem2.Content = szamok[1];
            listItem3.Content = szamok[2];
            listItem4.Content = szamok[3];
            listItem5.Content = szamok[4];
            listItem6.Content = szamok[5];
        }

        private void orderButton(object sender, RoutedEventArgs e)
        {
            if ((bool)paros.IsChecked && (bool)tiz.IsChecked) { MessageBox.Show("Csak egyet válassz ki!"); }
            if ((bool)paros.IsChecked)
            {
                for (int i = 0; i < szamok.Count(); i++)
                {
                    if (szamok[i] % 2 == 0)
                    {
                        szamokR.Insert(i, szamok[i]);
                    }
                }
                oListItem1.Content = szamokR[0];
                oListItem2.Content = szamokR[1];
                oListItem3.Content = szamokR[2];
                oListItem4.Content = szamokR[3];
                oListItem5.Content = szamokR[4];
                oListItem6.Content = szamokR[5];
            }
            if ((bool)tiz.IsChecked)
            {
                for (int i = 0; i < szamok.Count(); i++)
                {
                    if (szamok[i] % 10 == 0)
                    {
                        szamokR.Insert(i, szamok[i]);
                    }
                }
                oListItem1.Content = szamokR[0];
                oListItem2.Content = szamokR[1];
                oListItem3.Content = szamokR[2];
                oListItem4.Content = szamokR[3];
                oListItem5.Content = szamokR[4];
                oListItem6.Content = szamokR[5];
            }
        }
    }
};