using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public DoublyLinkedList()
        {

        }
        public DoublyLinkedList(Node head, Node tail)
        {
            Head = head;
            Tail = tail;
        }

        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int count { get; private set; }

        public void AddFirst(int element)
        {
            if (count == 0)
            {
                Head = new Node(element);
                Tail = Head;
            }
            else
            {
                Node newHead = new Node(element);
                Head.Previous = newHead;
                newHead.Next = Head;
                Head = newHead;
            }
            count++;
        }

        public void AddLast(int element)
        {
            if (count == 0)
            {
                Head = new Node(element);
                Tail = Head;
            }
            else
            {
                Node newTail = new Node(element);
                Tail.Next = newTail;
                newTail.Previous = Tail;
                Tail = newTail;
            }
            count++;
        }

        public int RemoveFirst()
        {
  
            if (count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }
           
            int removedElement = Head.Value;
            Head = Head.Next;
           
            if (Head != null)
            {
                Head.Previous = null;
            }
            else
            {
                Tail = null;
            }
            count--;
            return removedElement;
        }

        public int RemoveLast()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }

            int removedElement = Tail.Value;
            Tail = Tail.Previous;

            if (Tail != null)
            {
                Tail.Next = null;
            }
            else
            {
                Head = null;
            }
            count--;
            return removedElement;
        }


    }
}
