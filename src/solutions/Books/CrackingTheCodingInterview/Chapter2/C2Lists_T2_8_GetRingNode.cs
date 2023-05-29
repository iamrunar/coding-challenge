using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_8_GetRingNode
    {
        public int GetRingNode(ListNode head)
        {
            ListNode runner=head, current=head;

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
        
        public int GetRingNode2(ListNode head)
        {
            HashSet<ListNode> nodes = new HashSet<ListNode>();
            while (true)
            {
                if (nodes.Contains(head)) return head.val;

                nodes.Add(head);
                head=head.next;
            }
        }
    }
}
