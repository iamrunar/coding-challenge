using solutions.Models;
using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_1_RemoveDuplicates
    {
        public ListNode RemoveDuplicates(ListNode head)
        {
            //cpu O(n)
            //mem O(n)
            HashSet<int> keys = new HashSet<int>();

            ListNode newHead = null, newCurrent = null;
            ListNode current = head;
            while (current!=null)
            {
                if (!keys.Contains(current.val))
                {
                    keys.Add(current.val);
                    var node = new ListNode(current.val);
                    if (newCurrent != null)
                    {
                        newCurrent.next = node;
                    }
                    else
                    {
                        newHead = node;
                    }
                    newCurrent = node;
                }

                current = current.next;
            }
            return newHead;
        }

        public ListNode RemoveDuplicates2(ListNode head)
        {
            //cpu O(n^2)
            //mem O(1)
            ListNode current = head;
            while (current != null)
            {
                ListNode runner = current;
                while (runner.next!=null)
                {
                    if (runner.next.val == current.val)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }

                current = current.next;
            }
            return head;
        }
    }
}
