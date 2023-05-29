using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_3_DeleteMiddleNode
    {
        public void DeleteMiddleNode(ref ListNode head)
        {
            ListNode previousMiddleNode = GetPreviousMiddleNode(head);
            if (previousMiddleNode == null)
            {
                head = head.next;
                return ;
            }
            RemoveNextNode(previousMiddleNode);

            ListNode GetPreviousMiddleNode(ListNode h)
            {
                var runner = h;
                var middle = h;
                ListNode previous = null;
                while (runner.next!=null && runner.next.next!=null)
                {
                    previous = middle;

                    runner = runner.next.next;
                    middle = middle.next;
                }

                return previous;
            }

            void RemoveNextNode(ListNode previous)
            {
                previous.next = previous.next.next;
            }
        }
    }
}
