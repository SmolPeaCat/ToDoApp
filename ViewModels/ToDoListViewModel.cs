using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;
using SimpleTodoList.DataModel;

namespace SimpleTodoList.ViewModels;

public class ToDoListViewModel(IEnumerable<ToDoItem> items) : ViewModelBase
{
    public ObservableCollection<ToDoItem> ListItems { get; } = new ObservableCollection<ToDoItem>(items);
}


