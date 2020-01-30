using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using CustomLinkedList;
using System.Collections;

namespace CustomCollection
{
    /// <summary>
    /// Class to implement Custom Collection
    /// </summary>
    public class CustomCollectionClass : IEnumerator, IEnumerable
    {
        CustomLinkedListClass<int> list;
        int position = -1;
        //public object Current => throw new NotImplementedException();

        public CustomCollectionClass()
        {
            list= new CustomLinkedListClass<int>();
        }
        /// <summary>
        /// Method to add elements in Custom Collection
        /// </summary>
        /// <param name="data"> It is data to be added in Custom Collection</param>
        public void Add(int data)
        {
            list.Add(data);
        }
        /// <summary>
        ///  Method to remove elements in Custom Collection
        /// </summary>
        /// <param name="data">the data of the element to be removed</param>
        public void Remove(int data)
        {
            list.Remove(data);
        }
        /// <summary>
        /// The method is to perform sort of the elements in the Custom Collection
        /// </summary>
        public void MSort()
        {
            list.head = list.MergeSort(list.head);
        }
        /// <summary>
        /// Method to display elements in the Custom Collection
        /// </summary>
        public void Display()
        {
            list.Display();
        }
        /// <summary>
        /// Method to find element in the custom Collection
        /// </summary>
        public int FindElement(int data)
        {
            return list.FindElement(list.head, data);
        }
        public bool MoveNext()
        {
            position++;
            return (position < list.Length());
            //throw new NotImplementedException();
        }

        public void Reset()
        {
            position = 0;
            //throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
            //throw new NotImplementedException();
        }
        public object Current
        {
            get
            {
                return list.FindNth(position);
            }
        }
        /// <summary>
        /// Method to insert Nth element in Custom Collection
        /// </summary>
        /// <param name="data">the data of the element to be inserted</param>
        /// <param name="position">the index to be inserted</param>
        public void InsertNth(int data,int position)
        {
            list.InsertNth(data,position);
        }
        /// <summary>
        /// Method to find nth element in the custom collection
        /// </summary>
        /// <param name="index"></param>
        public int FindNth(int index)
        {
           return list.FindNth(index);
        }
        /// <summary>
        /// Method is to find length of the Custom Collection
        /// </summary>
        public int Length()
        {
            return list.Length();
        }

    }
        
        
      
}
