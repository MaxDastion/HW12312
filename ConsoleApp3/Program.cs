public interface IMyInterfase<T>
{
    void Add(int index, T element);
    T Get(int index);
    void Remove(int index);
}

public class ListBimbimBamBam<T> : IMyInterfase<T>
{
    private T[] array;

    public ListBimbimBamBam(int size)
    {
        array = new T[size];
    }
    public void Add(int index, T element)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = element;
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    public T Get(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return array[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    public void Remove(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = default(T);
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    public void Sort()
    {
        Array.Sort(array);
    }

    public int Length
    {
        get { return array.Length; }
    }
}

class Program
{
    static void Main(string[] args) { 
        ListBimbimBamBam<int> ints = new ListBimbimBamBam<int>(3);
        ints.Sort();
        ints.Add(2,6);
        Console.WriteLine(  ints.Length);
    }
}
