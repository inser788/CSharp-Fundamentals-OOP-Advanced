using System;
using System.Collections.Generic;

public class ListyIterator<T>
{
    private readonly List<T> collection;

    private int currentIndex;

    public ListyIterator(IEnumerable<T> collection)
    {
        this.collection=new List<T>(collection);
        this.currentIndex = 0;
    }

    public ListyIterator() :
        this(new List<T>())
    {
    }

    public bool HasNext() => this.currentIndex < this.collection.Count - 1;

    public bool Move()
    {
        var canMove = this.HasNext();
        if (canMove)
        {
            this.currentIndex++;
        }

        return canMove;
    }

    public void Print()
    {
        if (this.collection.Count==0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        Console.WriteLine($"{this.collection[this.currentIndex]}");
    }

}

