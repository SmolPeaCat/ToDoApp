using System.Reactive.Linq;
using ReactiveUI;
using System;
using SimpleTodoList.DataModel;
using SimpleTodoList.Services;
using SimpleTodoList.Views;

namespace SimpleTodoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    private AddNewToDoViewModel _addNewTodoViewModel;
    public MainWindowViewModel()
    {
        var service = new ToDoListServices();
        SimpleToDoList = new ToDoListViewModel(service.GetItems());
        _contentViewModel = SimpleToDoList;
        _addNewTodoViewModel = new AddNewToDoViewModel();
    }
    public ToDoListViewModel SimpleToDoList { get; }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public AddNewToDoViewModel AddNewTodoViewModel
    {
        get => _addNewTodoViewModel;
    }
    public void NewToDo()
    { 
        // Create a new window
        var windowTracker = WindowTracker.Instance;
        var numWindows = windowTracker.GetWindowsCount();
        Console.WriteLine(numWindows);
        
        if (numWindows > 1) return; // limit the number of windows
        
        var addNewTodoWindow = new AddNewToDo
        {
            DataContext = AddNewTodoViewModel
        };
        addNewTodoWindow.Show();
        windowTracker.RegisterWindow();

        AddNewTodoViewModel.AddCommand.Merge(AddNewTodoViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
            .Take(1)
            .Subscribe(newItem =>
            {
                if (newItem != null)
                {
                    SimpleToDoList.ListItems.Add(newItem);
                }
                addNewTodoWindow.Close();
                windowTracker.UnRegisterWindow();
            });
    }
}