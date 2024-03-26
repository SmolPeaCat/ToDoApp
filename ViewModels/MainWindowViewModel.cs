using Avalonia.Controls;
using ReactiveUI;
using SimpleTodoList.Services;
using SimpleTodoList.Views;

namespace SimpleTodoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    private AddNewToDoViewModel _addNewTodoWindow;
    public MainWindowViewModel()
    {
        var service = new ToDoListServices();
        SimpleToDoList = new ToDoListViewModel(service.GetItems());
        _contentViewModel = SimpleToDoList;
        _addNewTodoWindow = new AddNewToDoViewModel();
    }
    public ToDoListViewModel SimpleToDoList { get; }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void NewToDo()
    {
        var addNewTodoView = new AddNewToDo();
        addNewTodoView.DataContext = _addNewTodoWindow;
        addNewTodoView.Show();
    }
}