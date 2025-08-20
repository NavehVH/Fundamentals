
using System;

namespace Fundamentals.LeetCode
{
    public class ListNode
    {
        private int val;
        private ListNode next;
        private ListNode(int val = 0, ListNode next = null)
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

        public static ListNode Reverse(ListNode head)
        {
            ListNode prev = null, cur = head, after = null;

            if (head == null)
                return null;

            while (cur != null)
            {
                after = cur.next;
                cur.next = prev;
                prev = cur;
                cur = after;
            }
            return prev;
        }

        public static ListNode ReverseRecursive(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var newHead = ReverseRecursive(head.next); //last value and new pointer of our list

            head.next.next = head;
            head.next = null;

            return newHead;
        }

        public static ListNode MiddleNote(ListNode head)
        {
            ListNode slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = null;
            return slow;
        }

        public static int KValFromEnd(ListNode head, int k)
        {
            if (head == null || k <= 0) return -1;

            ListNode slow = head, fast = head;

            for (int i = 0; i < k; i++)
            {
                if (fast == null) return -1; // k > length
                fast = fast.next;
            }

            // advance both pointers
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow.val; // slow is k-th from end
        }
    }
}