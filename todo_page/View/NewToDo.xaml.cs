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
        public List<string> todos = new List<string>();
        private void addnew_Click(object sender, RoutedEventArgs e)
        {
            if (userinput.Text != "")
            {
                string newtodo = userinput.Text;
                todos.Add(newtodo);
                userinput.Text = "";
            }
            else
            {
                MessageBox.Show("Nem hagyhatod üresen!");
            }
        }
    }
};