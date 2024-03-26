using System.Collections.Generic;
using SimpleTodoList.DataModel;

namespace SimpleTodoList.Services;

public class ToDoListServices
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Walk the dragon" },
        new ToDoItem { Description = "Buy some metal scraps for Fuhr" },
        new ToDoItem { Description = "Learn to speak Avalonian" },
    };
}