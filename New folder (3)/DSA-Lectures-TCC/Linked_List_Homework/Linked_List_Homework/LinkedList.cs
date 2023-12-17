using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
          if (First == null)
        {
             First = new Node { Data = val };
        }
           else
        {
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = new Node { Data = val };
        }

            
        }
        public void RemoveKey(int key)
        {
                if (First == null) return;

    if (First.Data == key)
    {
        First = First.Next;
        return;
    }

    Node move = First;
    while (move.Next != null)
    {
        if (move.Next.Data == key)
        {
            move.Next = move.Next.Next;
            return;
        }
        move = move.Next;
    }
        }
        public void Merge(LinkedList other_list)
        {
                if (other_list.First == null) return;

    if (First == null)
    {
        First = other_list.First;
    }
    else
    {
        Node move = First;
        while (move.Next != null)
        {
            move = move.Next;
        }
        move.Next = other_list.First;
    }
        }
        public void Reverse()
        {
             if (First == null || First.Next == null) return;

    Node prev = null;
    Node curr = First;
    Node next = null;

    while (curr != null)
    {
        next = curr.Next;
        curr.Next = prev;
        prev = curr;
        curr = next;
    }

    First = prev;
        }
    }
}



