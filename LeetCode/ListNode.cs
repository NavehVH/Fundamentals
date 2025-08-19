
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

        public static bool isEmpty(ListNode head)
        {
            return head == null;
        }
        public static int Length(ListNode head)
        {
            int length = 0;
            ListNode temp = head;
            while (temp != null)
            {
                temp = temp.next;
                length++;
            }
            return length;
        }

        public static ListNode InsertToList(ListNode head, int x)
        {
            return new ListNode(x, head);
        }

        public static ListNode InsertToEndOfList(ListNode head, int x)
        {
            ListNode temp = head;
            if (temp == null)
                return new ListNode(x, null);

            while (temp.next != null)
                temp = temp.next;

            temp.next = new ListNode(x, null);
            return head;
        }

        public static int[] ListToArray(ListNode head)
        {
            int[] array = new int[Length(head)];
            ListNode temp = head;
            int i = 0;
            while (temp != null)
            {
                array[i] = temp.val;
                i++;
                temp = temp.next;
            }
            return array;
        }

        public static void ToString(ListNode head)
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