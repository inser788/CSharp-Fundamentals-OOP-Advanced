using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GenericCollection<T>
{
    private List<T> collection;

    public GenericCollection()
    {
        this.collection=new List<T>();
    }

    public void AddItem(T item)
    {
        this.collection.Add(item);
    }

    public void SwapElements(int index1, int index2)
    {
        T swappedElement = this.collection[index1];
        this.collection[index1] = this.collection[index2];
        this.collection[index2] = swappedElement;
    }

    public string Print()
    {
        StringBuilder sb=new StringBuilder();
        foreach (var item in collection)
        {
            sb.AppendLine($"{typeof(T).FullName}: {item}");
        }

        return sb.ToString().Trim();
    }
}

