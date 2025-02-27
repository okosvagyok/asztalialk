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
    /// Interaction logic for DeletePage.xaml
    /// </summary>
    public partial class DeletePage : Page
    {
        public DeletePage()
        {
            InitializeComponent();
            loadItemsDelete();
        }
        private void loadItemsDelete()
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            int listCount = mainWindow.todoList.Count;
            if (todos.Items.Count < listCount)
            {
                for (int i = 0; i < listCount; i++)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Content = mainWindow.todoList[i];
                    mainWindow.todoList.Add(item.ToString());
                    todos.Items.Add(item.Content);
                }
            }
        }
    }
}
