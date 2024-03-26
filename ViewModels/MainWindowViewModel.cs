using ReactiveUI;
using SimpleTodoList.Services;

namespace SimpleTodoList.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;

    public MainWindowViewModel()
    {
        var service = new ToDoListServices();
        SimpleToDoList = new ToDoListViewModel(service.GetItems());
        _contentViewModel = SimpleToDoList;
    }
    public ToDoListViewModel SimpleToDoList { get; }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }
}