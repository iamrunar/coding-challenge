using ListNode = solutions.Models.LinkedListNode3<int>;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_4_Partition
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode hLittle = null, pLittle = null,
                            hGreater = null, pGreater = null,
                            hEq = null, pEq = null,
                            current = head, next;
            while (current != null)
            {
                next = current.next;
                if (current.val < x)
                {
                    if (hLittle == null)
                    {
                        hLittle = pLittle = current;
                    }
                    else
                    {
                        pLittle.next = current;
                        pLittle = current;
                    }
                }
                else if (current.val > x)
                {
                    if (hGreater == null)
                    {
                        hGreater = pGreater = current;
                    }
                    else
                    {
                        pGreater.next = current;
                        pGreater = current;
                    }
                }
                else //n.val == x
                {
                    if (hEq == null)
                    {
                        hEq = pEq = current;
                    }
                    else
                    {
                        pEq.next = current;
                        pEq = current;
                    }
                }
                current = next;
            }
            var h = hLittle ?? hEq ?? hGreater;
            if (pLittle != null)
            {
                pLittle.next = hEq ?? hGreater;
            }
            if (pEq != null)
            {
                pEq.next = hGreater;
            }
            if (pGreater != null)
            {
                pGreater.next = null;
            }
            return hLittle ?? hEq ?? hGreater;
        }

        public ListNode Partition2(ListNode inputHead, int x)
        {
            ListNode head = inputHead,
                            tail = inputHead,
                            node = inputHead,
                            next;

            while (node != null)
            {
                next = node.next;

                if (node.val < x)
                {
                    node.next = head;
                    head = node;
                }
                else if (node.val >= x)
                {
                    tail.next = node;
                    tail = node;
                }

                node = next;
            }
            tail.next = null;
            return head;
        }
    }
}
