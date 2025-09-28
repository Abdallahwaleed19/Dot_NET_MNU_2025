using System;
namespace MergedTwoSortedLists
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
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage:
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            Solution solution = new Solution();
            ListNode mergedList = solution.MergeTwoLists(list1, list2);
            PrintList(mergedList); // Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4
        }
        static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " -> ");
                node = node.next;
            }
            Console.WriteLine("null");
        }
    }
}