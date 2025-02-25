using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace todo_page.View
{
    /// <summary>
    /// Interaction logic for NewToDo.xaml
    /// </summary>
    public partial class NewToDo : Page
    {
        public NewToDo()
        {
            InitializeComponent();
        }
        public int items = 0;
        private void userinput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (userinput.Text == "Mit kell csinálnod?")
            {
                userinput.Text = "";
            }
        }
        private void addnew_Click(object sender, RoutedEventArgs e)
        {
            string newItem = userinput.Text;
            if (newItem != "" || newItem != "Mit kell csinálnod?")
            {
                items++;
                //todos.Items.Add(items + ". " + newItem);
                userinput.Text = "Mit kell csinálnod?";
                MessageBox.Show("Tennivaló hozzáadva!");
            }
            else
            {
                MessageBox.Show("Írj be egy tennivalót!");
            }
        }
    }
}
