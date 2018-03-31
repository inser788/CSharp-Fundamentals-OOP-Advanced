using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private T data;

    public Box(T item)
    {
        this.data = item;
    }

   
    public override string ToString()
    {
       // return $"{this.data.GetType().FullName}: {this.data}";
        return $"{typeof(T).FullName}: {this.data}";
    }
}

