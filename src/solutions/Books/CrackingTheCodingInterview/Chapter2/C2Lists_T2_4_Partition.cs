using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_4_Partition
    {
        public LinkedListNode2 Partition(LinkedListNode2 head, int x)
        {
            LinkedListNode2 hLittle = null,pLittle = null,
                            hGreater = null,pGreater = null,
                            hEq = null,pEq = null,
                            current=head, next;
            while (current!=null)
            {
                next = current.next;
                if (current.val < x)
                {
                    if (hLittle==null)
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
                    if (hGreater==null)
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
                    if (hEq==null)
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
            if (pLittle !=null)
            {
                pLittle.next = hEq ?? hGreater;
            }
            if (pEq!=null)
            {
                pEq.next = hGreater;
            }
            if (pGreater!=null)
            {
                pGreater.next = null;
            }
            return hLittle ?? hEq ?? hGreater;
        }

        public LinkedListNode2 Partition2(LinkedListNode2 head, int x)
        {
            LinkedListNode2 h=head,t=head, n = head, next;

            while (n!=null)
            {
                next = n.next;

                if (n.val<x)
                {
                    if (h!=n)
                        n.next = h;
                    h=n;
                }
                else if (n.val>=x)
                {
                    if (t!=n)
                    t.next = n;
                    t = n;
                }

                n = next;
            }
            t.next = null;
            return h ;
        }
    }
}