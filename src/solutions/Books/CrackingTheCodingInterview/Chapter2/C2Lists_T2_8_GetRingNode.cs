using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_8_GetRingNode
    {
        public int GetRingNode(LinkedListNode2 head)
        {
            LinkedListNode2 runner=head, current=head;

            do
            {
                current = current.next;
                runner = runner.next.next;
            }
            while (current!=runner);

            current = head;
            while (current!=runner)
            {
                current = current.next;
                runner = runner.next;
            }

            return current.val;
        }
        
        public int GetRingNode2(LinkedListNode2 head)
        {
            HashSet<LinkedListNode2> nodes = new HashSet<LinkedListNode2>();
            while (true)
            {
                if (nodes.Contains(head)) return head.val;

                nodes.Add(head);
                head=head.next;
            }
        }
    }
}
