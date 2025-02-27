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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
            loadItems();
        }
        private void loadItems()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            foreach (var item in mainWindow.todoList)
            {
                //todolist.Items.Add(item);
            }
        }
    }
}
