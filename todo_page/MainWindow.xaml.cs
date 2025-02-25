﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using todo_page.View;

namespace todo_page;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public int items = 0;
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        var MainPage = new MainPage();
        MainFrame.Content = MainPage;
    }

    private void NewToDo_Click(object sender, RoutedEventArgs e)
    {
        var addNewToDo = new NewToDo();
        MainFrame.Content = addNewToDo;
    }
}