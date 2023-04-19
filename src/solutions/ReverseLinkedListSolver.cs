using solutions.Models;

namespace solutions.easy;

public class ReverseLinkedListRecursionSolver
{
    public LinkedListNode2 ReverseList(LinkedListNode2 n)
    {
        if (n == null || n.next == null)
        {
            return n;
        }

        LinkedListNode2 newHead = ReverseList(n.next);

        n.next.next = n;
        n.next = null;

        return newHead;
    }
}

public class ReverseLinkedListValuesLinearSolver
{
    public LinkedListNode2 ReverseList1(LinkedListNode2 n)
    {
        Stack<LinkedListNode2> stack = new Stack<LinkedListNode2>();

        var c = n;
        while (c!=null)
        {
            stack.Push(c);
            c = c.next;
        }

        c = null;
        while (stack.TryPop(out LinkedListNode2 p))
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
    public LinkedListNode2 ReverseList(LinkedListNode2 n)
    {
        LinkedListNode2 next = n, prev = null;

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
