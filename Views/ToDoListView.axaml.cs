using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace SimpleTodoList.Views;

public partial class ToDoListView : UserControl
{
    public ToDoListView()
    {
        InitializeComponent();
        MakeItBeautiful();
    }
    private void MakeItBeautiful()
    {
        var gradientBrush = new LinearGradientBrush();
        gradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.3));
        gradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, 1.0));
        gradientBrush.Opacity = 100.0;
        BackOfToDos.Background = gradientBrush;
    }

}
