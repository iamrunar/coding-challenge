using solutions.Models;

namespace solutions.easy;

public class ReverseLinkedListSolver
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
