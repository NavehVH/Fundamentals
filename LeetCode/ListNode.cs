
using System;

namespace Fundamentals.LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static void PrintList(ListNode head)
        {
            ListNode curr = head;
            while (curr != null)
            {
                Console.Write(curr.val + " -> ");
                curr = curr.next;
            }
            Console.WriteLine("null");
        }
    }
}