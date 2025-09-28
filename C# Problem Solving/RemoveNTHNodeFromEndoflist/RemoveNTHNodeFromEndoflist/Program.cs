using System;


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


public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode slow = dummy;
        ListNode fast = dummy;

        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}


public class Program
{
    
    public static void Main(string[] args)
    {
       
        Solution solver = new Solution();

     
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        int n = 2;

        Console.Write("Original List: ");
        PrintList(head);

       
        ListNode newHead = solver.RemoveNthFromEnd(head, n);

        
        Console.Write("List after removing {0}nd node from end: ", n);
        PrintList(newHead);
    }

  
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " -> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }
}