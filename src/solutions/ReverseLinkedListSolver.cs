using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.easy;

public class ReverseLinkedListRecursionSolver
{
    public ListNode ReverseList(ListNode n)
    {
        if (n == null || n.next == null)
        {
            return n;
        }

        ListNode newHead = ReverseList(n.next);

        n.next.next = n;
        n.next = null;

        return newHead;
    }
}

public class ReverseLinkedListValuesLinearSolver
{
    public ListNode ReverseList1(ListNode n)
    {
        Stack<ListNode> stack = new Stack<ListNode>();

        var c = n;
        while (c!=null)
        {
            stack.Push(c);
            c = c.next;
        }

        c = null;
        while (stack.TryPop(out ListNode p))
        {
            if (c == null)
            {
                n = c = p;
                continue;
            }
            c.next = p;
            c = p;
            c.next = null;
        }
        return n;
    }
    public ListNode ReverseList(ListNode n)
    {
        ListNode next = n, prev = null;

        while (next != null)
        {
            var current = next;
            next = current.next;
            current.next = prev;
            prev = current;
        }

        return prev;
    }
}
