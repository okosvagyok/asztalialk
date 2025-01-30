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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int items = 0;
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            string newItem = userInput.Text;
            if (newItem != "")
            {
                items++;
                todoList.Items.Add(items + ". " + newItem);
                countTodos();
                userInput.Text = "";
                MessageBox.Show("Tennivaló hozzáadva!");
            }
            else
            {
                MessageBox.Show("Írj be egy tennivalót!");
            }
        }
        private void userInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (userInput.Text == "Adj meg egy tennivalót!")
            {
                userInput.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (todoList.SelectedIndex != -1)
            {
                todoList.Items.RemoveAt(todoList.SelectedIndex);
                UpdateItemIndixes();
                countTodos();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!");
            }
        }
        private void UpdateItemIndixes()
        {
            for (int i = 0; i < todoList.Items.Count; i++)
            {
                string item = todoList.Items[i].ToString();
                int dotIndex = item.IndexOf(". ");
                if (dotIndex != -1)
                {
                    todoList.Items[i] = (i + 1) + item.Substring(dotIndex);
                }
            }
            items = todoList.Items.Count;
        }

        private void deleteAllBtn_Click(object sender, RoutedEventArgs e)
        {
            if (todoList.Items.Count != 0)
            {
                todoList.Items.Clear();
                countTodos();
                items = 0;
                MessageBox.Show("Minden tennivaló törölve!");
            }
            else
            {
                MessageBox.Show("Nincs mit törölni!");
            }
        }
        private void countTodos()
        {
            todoCount.Text = todoList.Items.Count.ToString();
        }
    }
};