using System.Collections.Generic;
using Avalonia.Controls;

namespace SimpleTodoList.Services;

public class WindowTracker
/*
 * Helper Class to keep track of the opened Windows
 * Decided to go with a Singleton pattern since I only need one instance
 */
{
    private static WindowTracker? _instance;
    private static int _windowCount = 0;
    
    private WindowTracker() {}
    public static WindowTracker Instance
    {
        get
        {
            _instance ??= new WindowTracker(); // if right is null create the left 
            return _instance;
        }
    }
    
    public void RegisterWindow()
    {
        _windowCount++;
    }

    public void UnRegisterWindow()
    {
        _windowCount--;
    }

    public int GetWindowsCount()
    {
        return _windowCount;
    }
    
}