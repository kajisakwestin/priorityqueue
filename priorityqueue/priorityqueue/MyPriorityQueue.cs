using System;
using System.Collections.Generic;
using System.Linq;

public class PriorityQueue<T>
{
    private List<Tuple<T, int>> elements = new List<Tuple<T, int>>();

    public void Enqueue(T item, int priority)
    {
        elements.Add(Tuple.Create(item, priority));
    }

    public T Dequeue()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Priority queue is empty");
        }
        var maxIndex = 0;
        for (var i = 0; i < elements.Count; i++)
        {
            if (elements[i].Item2 < elements[maxIndex].Item2)
            {
                maxIndex = i;
            }
        }
        var item = elements[maxIndex].Item1;
        elements.RemoveAt(maxIndex);
        return item;
    }

    public int Count
    {
        get { return elements.Count; }
    }
}
