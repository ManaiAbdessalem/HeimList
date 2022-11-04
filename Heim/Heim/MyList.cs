using System.Collections;

namespace Heim;

public class MyList<T> : IList<T>
{
    private readonly IList<T> _list = new List<T>();

    public T this[int index]
    {
        get
        {
            try
            {
                return _list[index];
            }
            catch (ArgumentOutOfRangeException)
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
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"The Index {index} is out of range!");
            }
        }
    }

    public int Count
    {
        get { return _list.Count; }
    }

    public void Add(T item)
    {
        _list.Add(item);
    }

    public void Clear()
    {
        _list.Clear();
    }

    public bool Contains(T item)
    {
        return _list.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _list.GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return _list.IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        _list.Insert(index, item);
    }

    public bool Remove(T item)
    {
        return _list.Remove(item);
    }

    public void RemoveAt(int index)
    {
        try
        {
            _list.RemoveAt(index);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Cannot remove at Index {index} . It is out of range!");
        }
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