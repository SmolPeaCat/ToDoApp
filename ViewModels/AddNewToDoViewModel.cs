using System.Reactive;
using ReactiveUI;
using SimpleTodoList.DataModel;
using SimpleTodoList.Services;

namespace SimpleTodoList.ViewModels;

public class AddNewToDoViewModel : ViewModelBase
{
    private string _description = string.Empty;
    public ReactiveCommand<Unit, ToDoItem> AddCommand { get; }
    public ReactiveCommand<Unit, Unit> CancelCommand { get; }

    public AddNewToDoViewModel()
    {
        var isValidObservable = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrWhiteSpace(x));
        AddCommand = ReactiveCommand.Create(
            () => new ToDoItem { Description = Description }, isValidObservable);
        CancelCommand = ReactiveCommand.Create(() => { });
    }

    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }

}