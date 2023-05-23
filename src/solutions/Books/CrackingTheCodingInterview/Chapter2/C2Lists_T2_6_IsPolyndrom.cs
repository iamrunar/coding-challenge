using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_6_IsPolyndrom
    {
        public bool IsPolyndrom(LinkedListNode2 node)
        {
            LinkedListNode2 resultIfWeFinished = node;
            return CheckEqualAndGetNextHeadNode(node, node) == resultIfWeFinished;

            LinkedListNode2 CheckEqualAndGetNextHeadNode(LinkedListNode2 node, LinkedListNode2 head)
            {
                if (node == null) return head;

                var nextHead = CheckEqualAndGetNextHeadNode(node.next, head);
                if (nextHead==null) return null;
                
                if (nextHead.val == node.val) return nextHead.next ?? resultIfWeFinished;

                return null;
            }
        }

        public bool IsPolyndrom2(LinkedListNode2 node)
        {
            Stack<int> firstPartOfList = new Stack<int>(node.val);
            LinkedListNode2 slow = node, fast=node;

            do
            {
                firstPartOfList.Push(slow.val);

                fast = fast?.next?.next;
                slow = slow.next;
            }
            while (fast?.next!=null);

            if (fast!=null)
                slow = slow.next;

            while (slow!=null)
            {
                int v ;
                if (!firstPartOfList.TryPop(out v)) return false;

                if (v != slow.val) return false;
                slow=slow.next;
            }

            return true;
        }
    }
}
