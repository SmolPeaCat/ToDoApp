using System.Collections.Generic;
using SimpleTodoList.DataModel;

namespace SimpleTodoList.Services;

public class ToDoListServices
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Walk the dragon", Id = 1},
        new ToDoItem { Description = "Buy some metal scraps for Myself", Id = 2},
        new ToDoItem { Description = "Learn to speak Avalonian", Id = 3},
    };
}
