using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_3_DeleteMiddleNode
    {
        public void DeleteMiddleNode(ref LinkedListNode2 head)
        {
            LinkedListNode2 previousMiddleNode = GetPreviousMiddleNode(head);
            if (previousMiddleNode == null)
            {
                head = head.next;
                return ;
            }
            RemoveNextNode(previousMiddleNode);

            LinkedListNode2 GetPreviousMiddleNode(LinkedListNode2 h)
            {
                var runner = h;
                var middle = h;
                LinkedListNode2 previous = null;
                while (runner.next!=null && runner.next.next!=null)
                {
                    previous = middle;

                    runner = runner.next.next;
                    middle = middle.next;
                }

                return previous;
            }

            void RemoveNextNode(LinkedListNode2 previous)
            {
                previous.next = previous.next.next;
            }
        }
    }
}
