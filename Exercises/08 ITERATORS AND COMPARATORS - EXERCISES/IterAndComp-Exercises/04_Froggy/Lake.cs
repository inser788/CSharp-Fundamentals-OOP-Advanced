using System;
using System.Collections;
using System.Collections.Generic;

public class Lake:IEnumerable<int>
{
    private List<int> collection;

    public Lake(List<int> collection)
    {
        this.collection =new List<int>(collection);
    }


    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.collection.Count; i+=2)
        {
            yield return this.collection[i];
        }

        int lastIndex = this.collection.Count - 1;

        if (lastIndex % 2 == 0)
            lastIndex--;

        for (int i = lastIndex; i >= 0; i-=2)
        {
            yield return this.collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

