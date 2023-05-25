using solutions.Models;

namespace solutions.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_7_GetConnectionNode
    {
        public LinkedListNode2 GetConnectionNode(LinkedListNode2 list1, LinkedListNode2 list2)
        {
            HashSet<LinkedListNode2> nodesOfFirstList = new HashSet<LinkedListNode2>();
            for (LinkedListNode2 c1 = list1; c1!=null; c1=c1.next) nodesOfFirstList.Add(c1);

            for (LinkedListNode2 c2 = list2; c2!=null; c2=c2.next) 
                if (nodesOfFirstList.Contains(c2))
                {
                    return c2;
                }

            return null;
        }

        public LinkedListNode2 GetConnectionNode2(LinkedListNode2 list1, LinkedListNode2 list2)
        {
            LinkedListNode2 p1 = list1, p2 = list2;

            int length1 = getLength(p1), 
                length2=getLength(p2);
            if (length1>length2)
            {
                p1 = skip(p1, length1-length2);
            }
            else if (length1<length2)
            {
                p2 = skip(p2, length2-length1);
            }

            return getFirstEqualsNode(p1,p2);

            int getLength(LinkedListNode2 head)
            {
                int l = 0;
                while (head!=null) 
                {
                    l++;
                    head=head.next;
                }
                return l;
            }

            LinkedListNode2 skip(LinkedListNode2 head, int skipNElements)
            {
                while (skipNElements-->0) head=head.next;
                return head;
            }

            LinkedListNode2 getFirstEqualsNode(LinkedListNode2 head1, LinkedListNode2 head2)
            {
                while (head1!=null)
                {
                    if (head1==head2) break;

                    head1=head1.next;
                    head2=head2.next;
                }

                return head1;
            }
        }
    }
}
