using System.Reactive.Linq;
using ReactiveUI;
using System;
using System.Diagnostics;
using System.Reactive;
using System.Windows.Input;
using SimpleTodoList.DataModel;
using SimpleTodoList.Services;
using SimpleTodoList.Views;

namespace SimpleTodoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    public ToDoListViewModel SimpleList { get; set; }
    private AddNewToDoViewModel AddNewTodoViewModel { get; }
    public ReactiveCommand<ToDoItem,Unit> DeleteToDoCommand { get; }
   
    
    public MainWindowViewModel()
    {
        var service = new ToDoListServices();
        SimpleList = new ToDoListViewModel(service.GetItems()); // adds the mockup data
        _contentViewModel = SimpleList;
        AddNewTodoViewModel = new AddNewToDoViewModel();
        DeleteToDoCommand = ReactiveCommand.Create<ToDoItem>(parameter => DeleteTodo(parameter));
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void NewToDo()
    { 
        // Creates a new window
        var windowTracker = WindowTracker.Instance;
        var numWindows = windowTracker.GetWindowsCount();
        Console.WriteLine(numWindows);
        
        if (numWindows > 1) return; // limit the number of windows to 2
        
        var addNewTodoWindow = new AddNewToDo
        {
            DataContext = AddNewTodoViewModel
        };
        addNewTodoWindow.Show();
        windowTracker.RegisterWindow();

        AddNewTodoViewModel.AddCommand.Merge(AddNewTodoViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
            .Take(1) // Only takes the first call
            .Subscribe(newItem => 
                // if the new Item is null it means that cancel was clicked
            {
                if (newItem != null)
                {
                    SimpleList.ListItems.Add(newItem);
                }
                addNewTodoWindow.Close();
                windowTracker.UnRegisterWindow();
            });
    }

    private void DeleteTodo(ToDoItem toDoItem)
    {
        SimpleList.ListItems.Remove(toDoItem);
    }
}