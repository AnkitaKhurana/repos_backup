using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLL
{
    class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class LinkedList
    {
       public ListNode Create()
        {
            int x;
            ListNode head = null;
            ListNode tail = null;

            while (true)
            {
                x = int.Parse(Console.ReadLine());
                if (x == -1) break;
                ListNode CurrentNode = new ListNode(x);
                if (head == null)
                {
                    head = CurrentNode;
                    tail = CurrentNode;
                }
                else
                {
                    tail.next = CurrentNode;
                    tail = tail.next;
                }
                return head;
            }
            return head;
        }

        public void printList(ListNode head)
        {
            ListNode currentNode = head;
            while (currentNode!=null)
            {
                Console.Write(currentNode.data);
                currentNode = currentNode.next;
            }
        }

        public ListNode Reverse(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode startOfRemList = head.next;
            startOfRemList = Reverse(startOfRemList);
            head.next.next = head;

            head.next = null;
            return startOfRemList;
        }

        
    }
}
