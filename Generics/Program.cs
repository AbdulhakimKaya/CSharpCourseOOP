﻿namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        List<string> cities = new List<string>();
        cities.Add("Ankara");
        cities.Add("Ankara");
        cities.Add("Ankara");
        cities.Add("Ankara");
        Console.WriteLine(cities.Count);

        MyList<string> cities2 = new MyList<string>();
        cities2.Add("Ankara");
        cities2.Add("Ankara");
        cities2.Add("Ankara");
        cities2.Add("Ankara");
        Console.WriteLine(cities2.Count);
    }
}

// Generic class
class MyList<T>
{
    private T[] _array;
    private T[] _tempArray;

    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length - 1] = item;
    }

    private int _count;

    public int Count
    {
        get { return _array.Length; }
    }
}