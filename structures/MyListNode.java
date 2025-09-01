package structures;

public class MyListNode {
    private int val;
    private MyListNode next;

    // Constructor
    private MyListNode(int val, MyListNode next) {
        this.val = val;
        this.next = next;
    }

    // Factory method for easier creation
    public static MyListNode of(int val) {
        return new MyListNode(val, null);
    }

    public static boolean isEmpty(MyListNode head) {
        return head == null;
    }

    public static int length(MyListNode head) {
        int length = 0;
        MyListNode temp = head;
        while (temp != null) {
            temp = temp.next;
            length++;
        }
        return length;
    }

    public static void printList(MyListNode head) {
        MyListNode curr = head;
        while (curr != null) {
            System.out.print(curr.val + " -> ");
            curr = curr.next;
        }
        System.out.println("null");
    }

    public static MyListNode insertToList(MyListNode head, int x) {
        return new MyListNode(x, head);
    }

    public static MyListNode insertToEndOfList(MyListNode head, int x) {
        if (head == null)
            return new MyListNode(x, null);

        MyListNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = new MyListNode(x, null);
        return head;
    }

    public static int[] listToArray(MyListNode head) {
        int[] array = new int[length(head)];
        MyListNode temp = head;
        int i = 0;
        while (temp != null) {
            array[i++] = temp.val;
            temp = temp.next;
        }
        return array;
    }

    public static MyListNode reverse(MyListNode head) {
        MyListNode prev = null, cur = head, after;
        while (cur != null) {
            after = cur.next;
            cur.next = prev;
            prev = cur;
            cur = after;
        }
        return prev;
    }

    public static MyListNode reverseRecursive(MyListNode head) {
        if (head == null || head.next == null)
            return head;

        MyListNode newHead = reverseRecursive(head.next);
        head.next.next = head;
        head.next = null;

        return newHead;
    }

    public static MyListNode middleNode(MyListNode head) {
        MyListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = null; // cut the list
        return slow;
    }

    public static int kValFromEnd(MyListNode head, int k) {
        if (head == null || k <= 0) return -1;

        MyListNode slow = head, fast = head;

        for (int i = 0; i < k; i++) {
            if (fast == null) return -1; // k > length
            fast = fast.next;
        }

        while (fast != null) {
            slow = slow.next;
            fast = fast.next;
        }

        return slow.val;
    }
}
