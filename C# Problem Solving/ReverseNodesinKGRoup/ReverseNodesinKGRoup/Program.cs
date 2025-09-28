using System;

// Definition for singly-linked list
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

// This class contains the logic to solve the problem
public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1) return head;

        ListNode current = head;
        for (int i = 0; i < k; i++)
        {
            if (current == null)
            {
                return head;
            }
            current = current.next;
        }

        ListNode prev = null;
        ListNode curr = head;
        for (int i = 0; i < k; i++)
        {
            ListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }

        head.next = ReverseKGroup(curr, k);

        return prev;
    }
}

// This class provides the entry point for the application
public class Program
{
    // The 'Main' method is the starting point for execution
    public static void Main(string[] args)
    {
        // 1. Create an instance of your Solution class
        Solution solver = new Solution();

        // 2. Create the sample linked list: 1 -> 2 -> 3 -> 4 -> 5
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        int k = 3;

        Console.Write("Original List: ");
        PrintList(head);

        // 3. Call the ReverseKGroup method
        ListNode newHead = solver.ReverseKGroup(head, k);

        // 4. Print the final result
        Console.Write("List after reversing in groups of {0}: ", k);
        PrintList(newHead); // Expected: 3 -> 2 -> 1 -> 4 -> 5 -> null
    }

    // Helper function to print a linked list
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