using System;
using System.Reactive;
using System.Windows.Input;
using ReactiveUI;

namespace SimpleTodoList.DataModel;

public class ToDoItem
{
   public int Id { get; set; }
   public string Description { get; set; } = String.Empty;
}