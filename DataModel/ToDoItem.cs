using System;

namespace SimpleTodoList.DataModel;

public class ToDoItem
{ 
   public string Description { get; set; } = String.Empty;
   public bool IsDone { get; set; }
   public bool IsDeleted { get; set; }
   
}