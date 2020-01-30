using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{/// <summary>
///  Internal Implementation of Custom Collection
/// </summary>

    public class CustomLinkedListClass<T>
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }
        /// <summary>
        /// Method to add elements in Custom Collection
        /// </summary>
        /// <param name="data"> It is data to be added in Custom Collection</param>
        public void Add(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            return;
        }
        /// <summary>
        /// Method to display elements in the Custom Collection
        /// </summary>
        public void Display()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;
            }
        }
        /// <summary>
        ///  Method to remove elements in Custom Collection
        /// </summary>
        /// <param name="data">the data of the element to be removed</param>
        public void Remove(int key)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null) return;


            prev.next = temp.next;
        }
        public Node sortedMerge(Node a, Node b)
        {
            Node result = null;

            if (a == null)
                return b;
            if (b == null)
                return a;


            if (a.data <= b.data)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }
        /// <summary>
        /// The method is to perform sort of the elements in the Custom Collection
        /// </summary>
        public Node MergeSort(Node h)
        {

            if (h == null || h.next == null)
            {
                return h;
            }
            Node middle = getMiddle(h);
            Node nextofmiddle = middle.next;
            middle.next = null;
            Node left = MergeSort(h);
            Node right = MergeSort(nextofmiddle);
            Node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }
        /// <summary>
        /// Method is to get middle element in Custom Collection
        /// </summary>
        /// <returns>Returns middle node of Custom Collection</returns>

        public Node getMiddle(Node h)
        {

            if (h == null)
                return h;
            Node fastptr = h.next;
            Node slowptr = h;
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }
        /// <summary>
        /// Method to find element in the custom Collection
        /// </summary>
        public int FindElement(Node head, int x)
        {
            int count = -1;
            Node current = head;
            while (current != null)
            {
                count++;
                if (current.data == x)
                {
                    return count;
                }
                current = current.next;

            }
            return count;
        }
        /// <summary>
        /// Method is to find length of the Custom Collection
        /// </summary>
        public int Length()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        /// <summary>
        /// Method to find nth element in the custom collection
        /// </summary>
        /// <param name="index"></param>
        public int FindNth(int index)
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                    return current.data;
                count++;
                current = current.next;
            }
            //Debug.Assert(false);
            return 0;
        }
        /// <summary>
        /// Method to insert Nth element in Custom Collection
        /// </summary>
        /// <param name="data">the data of the element to be inserted</param>
        /// <param name="position">the index to be inserted</param>
        public void InsertNth(int data, int position)
        {
            
            Node node = new Node(data);
            node.next = null;

            if (this.head == null)
            {
                if (position != 0)
                {
                    return;
                }
                else
                { 
                    this.head = node;
                }
            }

            if (head != null && position == 0)
            {
                node.next = this.head;
                this.head = node;
                return;
            }

            Node current = this.head;
            Node previous = null;

            int i = 0;

            while (i < position)
            {
                previous = current;
                current = current.next;

                if (current == null)
                {
                    break;
                }

                i++;
            }
        }
    }
}
