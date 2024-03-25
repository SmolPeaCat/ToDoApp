using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace SimpleTodoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MakeItBeautiful();
    }

    private void MakeItBeautiful()
    {
        var gradientBrush = new LinearGradientBrush();
        gradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
        gradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, 1.0));
        
        BackOfToDos.Background = gradientBrush;
        
    }
}