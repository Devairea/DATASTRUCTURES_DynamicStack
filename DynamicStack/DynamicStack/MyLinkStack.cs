using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicStack
{
    public class MyLinkStack
    {
        private class Node
        {
            //Instance variables
            internal int value;
            internal Node next;

            //Constructor
            public Node(int v, Node n)
            {
                value = v;
                next = n;
            }

            public int Value { get { return value; } }

            public Node Next { get { return next; } }
        }// end of private class node

        //Instance Variables for MyLinkStack
        private Node head;
        private int count;

        //Constructor
        public MyLinkStack()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Check if the list is full
        /// </summary>
        /// <returns>As a linked list can never be full it will always return false</returns>
        public bool Full(){return false;}

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns>true if there are no values in the list, else null</returns>
        public bool Empty(){return count == 0;}

        /// <summary>
        /// Check what size the list is
        /// </summary>
        /// <returns>The size of the linked list</returns>
        public int Size { get { return count; } }

        /// <summary>
        /// Add a new element to the list
        /// </summary>
        /// <param name="element">The element to be added</param>
        public void Push(int element)
        {
            head = new Node(element, head);
            count++;
        }

        /// <summary>
        /// Removing an element form the top of stack
        /// </summary>
        /// <returns>The value of the node before it was Poppped</returns>
        public int Pop()
        {
            if (Empty()) { throw new InvalidOperationException("The List is Empty"); }
            int element = head.Value;
            head = head.Next;
            count--;
            return element;
        }

        /// <summary>
        /// Look at the top value of the list
        /// </summary>
        /// <returns>the value store in head</returns>
        public int Peak()
        {
            if (Empty()) { throw new InvalidOperationException("The List is Empty"); }
            return head.Value;
        }

    }
}
