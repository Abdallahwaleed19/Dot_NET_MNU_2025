using System;
class Program
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
    }
    public static ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode newHead = head.next;
        ListNode prev = null;
        ListNode current = head;
        while (current != null && current.next != null)
        {
            ListNode nextPair = current.next.next;
            ListNode second = current.next;
            // Swap the pair
            second.next = current;
            current.next = nextPair;
            if (prev != null)
                prev.next = second;
            prev = current;
            current = nextPair;
        }
        return newHead;
    }
    static void Main(string[] args)
    {
        // Example usage:
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        ListNode swappedHead = SwapPairs(head);
        // Print the swapped list
        ListNode current = swappedHead;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
    }
}