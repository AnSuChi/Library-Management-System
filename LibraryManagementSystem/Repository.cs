using System;
using System.Collections.Generic;

// Interface using Generic type - can be anything, not strictly string, int, array etc.
// <T> = type parameter
public interface IRepository<T>
{
    // These must be present when implementing interface, or else you'll get red underline on IRepository<T>....bc obv. common for all classes using this interface is that these must be implemented
    void Add();
    void Remove();
}

// A class that implements the Repository interface
public class Repository<T> : IRepository<T>
{
    
    public void Add()
    {

    }

    public void Remove()
    {
        
    }

    public void Display()
    {
        
    }
}