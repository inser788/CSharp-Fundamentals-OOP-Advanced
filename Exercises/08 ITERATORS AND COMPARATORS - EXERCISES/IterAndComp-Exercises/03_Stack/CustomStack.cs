using System;
using System.Collections;
using System.Collections.Generic;

public class CustomStack<T>:IEnumerable<T>
{
    private List<T> customCollection;

    public CustomStack()
    {
        this.customCollection=new List<T>();
    }

    public void Push(T element)
    {
        this.customCollection.Add(element);
    }

    public T Pop()
    {
        if (this.customCollection.Count==0)
        {
            throw new InvalidOperationException("No elements");
        }

        var lastIndex = this.customCollection.Count - 1;
        var removedElement = this.customCollection[lastIndex];
        this.customCollection.RemoveAt(lastIndex);
        return removedElement;
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.customCollection.Count - 1; i >= 0; i--)
        {
            yield return this.customCollection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

