using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleTodoList.DataModel;

namespace SimpleTodoList.ViewModels;
public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }
    public ObservableCollection<ToDoItem> ListItems { get; }
}