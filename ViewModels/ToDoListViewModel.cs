using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;
using SimpleTodoList.DataModel;

namespace SimpleTodoList.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }

    public ObservableCollection<ToDoItem> ListItems { get; }

    public ReactiveCommand<Unit, ToDoItem> DoneCommand { get; }

    public void DeleteItem()
    {
    }
        
}


