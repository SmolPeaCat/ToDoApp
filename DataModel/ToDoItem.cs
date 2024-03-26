using System;

namespace SimpleTodoList.DataModel;

public class ToDoItem
{
   public int Id { get; set; }
   public string Description { get; set; } = String.Empty;
   public bool IsDone { get; set; }
}