using System;

namespace CoddingChallenge1
{
    
    public class LinkedList
    {
        public class Node // a node which contains a value
        {
            public Node next;
            public int value;

        }

        private Node head; // head of a list
        public int Length // property of a list length
        {
            get
            {
                int length = 0;
                Node current = head;
                if (head != null)
                {
                    length = 1;
                    while (current.next != null)
                    {
                        current = current.next;
                        length++;
                    }
                }
                return length;
            }
        }

        public void printList() // print all nodes one after another
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        public void addLast(int number) // add the node in the end of the list
        {
            if (head == null)
                head = new Node { value = number, next = null };
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node { value = number, next = null };
            }
        }

        public void addFirst(int number) // add the node in the begining of the list
        {
            if (head == null)
                head = new Node { value = number, next = null };
            else
            {
                Node prevHead = head;
                head = new Node { next = prevHead, value = number };
            }
        }

        public void insertNode(int number, int position) // insert a node in the list
        {
            if (position == 1) addFirst(number);
            else if (position > Length || position < 1) Console.WriteLine("Wrong position!");
            else
            {
                    Node current = head;
                    for (int i = 0; i < position - 2; i++)
                    {
                        current = current.next;
                    }
                    Node insertNode = new Node { next = current.next, value = number };
                    current.next = insertNode;
            }

        }
    }
}
