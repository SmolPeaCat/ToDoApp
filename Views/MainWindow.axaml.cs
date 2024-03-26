using System;
using Avalonia.Controls;
using SimpleTodoList.Services;
using Avalonia.Interactivity;
using SimpleTodoList.ViewModels;

namespace SimpleTodoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        WindowTracker windowTracker = new();
        windowTracker.RegisterWindow();
        Console.WriteLine(windowTracker.GetWindowsCount());
    }


}