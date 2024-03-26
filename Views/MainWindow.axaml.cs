using System;
using Avalonia.Controls;
using SimpleTodoList.Services;

namespace SimpleTodoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        WindowTracker windowTracker = WindowTracker.Instance;
        windowTracker.RegisterWindow();
    }


}