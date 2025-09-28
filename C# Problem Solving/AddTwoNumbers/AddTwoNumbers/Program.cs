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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode p = l1, q = l2, current = dummyHead;
        int carry = 0;

        while (p != null || q != null || carry != 0)
        {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;

            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }

        return dummyHead.next;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Example: l1 = [2,4,3], l2 = [5,6,4]
        // Represents 342 + 465 = 807
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        Solution solution = new Solution();
        ListNode result = solution.AddTwoNumbers(l1, l2);

        Console.WriteLine("Input l1: [2,4,3]");
        Console.WriteLine("Input l2: [5,6,4]");
        Console.Write("Output: "); // Expected: [7,0,8]
        PrintList(result);
    }

    // Helper function to print the linked list
    public static void PrintList(ListNode node)
    {
        Console.Write("[");
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null)
            {
                Console.Write(",");
            }
            node = node.next;
        }
        Console.WriteLine("]");
    }
}