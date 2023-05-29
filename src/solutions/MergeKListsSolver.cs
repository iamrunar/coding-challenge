using solutions.Models;
using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.easy;

public class MergeKListsSolver
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>(lists.Where(l=>l!=null).Select(x=>(x, x.val)));

        ListNode head = new ListNode(0);
        ListNode current = head;
        while (queue.TryDequeue(out ListNode node, out int p))
        {
            var newNode = new ListNode(node.val);
            current.next = newNode;
            current = newNode;

            var nodeNext = node.next;
            if (nodeNext!=null)
            {
                queue.Enqueue(nodeNext, nodeNext.val);
            }
        }
        return head.next;
    }
}

public class MergeTwoListsSolver
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode(0),
            current = head,
            p1 = list1,
            p2 = list2;

        while (p1 != null && p2 != null)
        {
            if (p1.val <= p2.val )
            {
                current.next = p1;
                p1 = p1.next;
            }
            else
            {
                current.next = p2;
                p2 = p2.next;
            }
            current = current.next;
        }

        current.next = p1 ?? p2;

        return head.next;
    }
}
