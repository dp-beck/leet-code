using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leet_code
{

    // Given the head of a singly linked list, return the middle node of the linked list.

    // If there are two middle nodes, return the second middle node.

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class MiddleOfTheLinkedListSolution1
    {
        // Time Complexity O(n); Space Complexity O(n)
        public ListNode MiddleNode(ListNode head)
        {
            var list = new List<ListNode>();
            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            return list[list.Count / 2];
        }
    }

    public class MiddleOfTheLinkedListSolution2
    {
        // Time Complext O(n); Space Complexity O(1)
        public ListNode MiddleNode(ListNode head)
        {
            ListNode end = head;
            ListNode middle = head;
            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;
        }
    }

}

