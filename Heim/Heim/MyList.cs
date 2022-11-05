using System.Collections;

namespace Heim;

public class MyList<T> : IList<T>
{
    private T[] _list { get; set; }

    public MyList(int length)
    {
        _list = new T[length];
    }

    public T this[int index]
    {
        get
        {
            try
            {
                return _list[index];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"The Index {index} is out of range!");
            }
            return default(T);
        }
        set
        {
            try
            {
                _list[index] = value;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"The Index {index} is out of range!");
            }
        }
    }

    public int Count
    {
        get { return _list.Length; }
    }

    public void Add(T item)
    {
        T[] newList = new T[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            newList[i] = _list[i];
        }
        newList[Count] = item;
        _list = newList;
    }

    public void Clear()
    {
        Array.Clear(_list, 0, _list.Length);
    }

    public bool Contains(T item)
    {
        return _list.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _list.AsEnumerable().GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(_list, item);
    }

    public void Insert(int index, T item)
    {
        T[] newList = new T[Count + 1];
        for (int i = 0; i < Count + 1; i++)
        {
            if (i < index)
            {
                newList[i] = _list[i];
            }
            if (index == i)
            {
                newList[i] = item;
            }
            if (i > index)
            {
                newList[i] = _list[i - 1];
            }
        }
        _list = newList;
    }

    public bool Remove(T item)
    {
        if (!Contains(item))
        {
            return false;
        }
        int i = IndexOf(item);
        RemoveAt(i);
        if (Contains(item))
        {
            Remove(item);
        }
        return true;
    }

    public void RemoveAt(int index)
    {
        if (index >= _list.Length)
        {
            Console.WriteLine($"Cannot remove at Index {index} . It is out of range!");
        }

        T[] newList = new T[Count - 1];
        for (int i = 0; i < Count - 1; i++)
        {
            if (i < index)
            {
                newList[i] = _list[i];
            }
            if (i >= index)
            {
                newList[i] = _list[i + 1];
            }
        }
        _list = newList;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #region skip

    public bool IsReadOnly => throw new NotImplementedException();

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    #endregion skip
}
