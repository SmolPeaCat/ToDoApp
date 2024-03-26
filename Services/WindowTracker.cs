using System.Collections.Generic;
using Avalonia.Controls;

namespace SimpleTodoList.Services;

public class WindowTracker
/*
 * Helper Class to keep track of the opened Windows
 */
{
    private int _openWindows;
    
    public void RegisterWindow()
    {
        _openWindows++;
    }

    public void UnRegisterWindow(Window window)
    {
        _openWindows--;
    }

    public int GetWindowsCount()
    {
        return _openWindows;
    }
    
}