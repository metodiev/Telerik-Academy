//
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
//clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid 
//positions.

using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;
using System.Linq;

public class GenericList<T>
     where T : IComparable
{
    //fields for class GenericList
    private ArrayList elements = new ArrayList();
    private int capacity;
   
    //field count
    private int count = 0;

    //constructor
    public GenericList(ArrayList element)
    {
        //capacity of array
        this.capacity = 100;
        //Array with fixed capacity
        this.elements.Capacity = capacity;
        this.elements = element;
    }

    //method for Adding element
    public void AddElement(T element)
    {
        //auto grow functionality
        if (this.elements.Count == this.capacity)
        {
            this.elements.Capacity = this.capacity + this.capacity;
        }

        else
        {
            this.elements.Add(element);
        }

    }

    //Method for accessing element by index
    public void AccessElements(int index, T add)
    {
        //auto grow functionality
        if (this.elements.Count == this.capacity)
        {
            this.elements.Capacity = this.capacity + this.capacity;
        }

        else
        {
            this.elements.Insert(index, add);
        }
    }

    // method Remoing element by index
    public void RemoveElement(int index)
    {
        this.elements.RemoveAt(index);
    }


    //Method inserting element at given position
    public void InsertElement(int index, T add)
    {
        //auto grow functionality
        if (this.elements.Count == this.capacity)
        {
            this.elements.Capacity = this.capacity + this.capacity;
        }

        else
        {
            this.elements.Insert(index, add);
        }
    }

    //Method for clearing the list
    public void ClearList()
    {
        this.elements.Clear();
    }



   //Method for finding Value
    public string FindValue(string find)
    { 
        string str = null;
        for (int i = 0; i < this.elements.Count; i++)
        {

            if (find.Contains(elements.ToString()) == true)
            {

                str = "Found string in Key " + i + "!";

            }
        }

            return str;
    }

    
    //override ToString method to return elements
    public override string ToString()
    {
        return string.Format("Elements", this.elements.ToString());
    }

    //create generic methods Min
    public int Min<T>()
    {
        this.elements.Sort();
        var minimum = this.elements.Count;
        //convert to array
        int[] arr = this.elements.ToArray(typeof(int)) as int[];
        int min = arr[0];

        return min;
    }

    //create generic merhods Max
    public int Max<T>()
    {
        this.elements.Sort();
        var maximum = this.elements.Count;
        //convert to array
        int[] arr = this.elements.ToArray(typeof(int)) as int[];
        int max = arr[maximum];

        return max;
    }
}


