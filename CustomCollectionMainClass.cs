using System;
using CustomCollection;

namespace CustomCollectionMain
{
    /// <summary>
    /// Executable class of custom collection
    /// </summary>
    class CustomCollectionMainClass
    {
        static void Main(string[] args)
        {
            CustomCollectionClass obj = new CustomCollectionClass();
            obj.Add(5);
            obj.Add(6);
            obj.Add(7);
            obj.Add(9);
            obj.Add(1);
            obj.Add(3);
            Console.WriteLine("Intial Elements");
            obj.Display();
            obj.Remove(7);
            Console.WriteLine("Elements after removing");
            obj.Display();
            obj.MSort();
            Console.WriteLine("Elements after sorting");
            obj.Display();
            obj.InsertNth(18, 0);
            Console.WriteLine("Elements after inserting 18 at th index");
            obj.Display();
            Console.WriteLine("Length of Custom Collection");
            Console.WriteLine(obj.Length());
            Console.WriteLine("Index of element 1");
            Console.WriteLine(obj.FindElement(1));
            Console.WriteLine("Element at index 2");
            Console.WriteLine(obj.FindNth(2));
            /* foreach(CustomLinkedListClass<int> c in obj)
             {
                 Console.WriteLine(c.head.data);
             }*/
        }
    }
}
