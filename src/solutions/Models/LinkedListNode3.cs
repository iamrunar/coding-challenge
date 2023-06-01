//rename to solutions.Common.Models
namespace solutions.Models;


public class LinkedListNode3<T>
{
    public LinkedListNode3<T> next;
    public T val;

    public LinkedListNode3(T val, LinkedListNode3<T> next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString();
    }
}


public static class LinkedListNode3BaseHelper
{
    public static LinkedListNode3<T>[] ToLinkedListArray<T>(this T[][] lists)
    {
        return lists.Select(n => n.ToLinkedList()).ToArray();
    }

    public static LinkedListNode3<T> ToLinkedList<T>(this T[] nums)
    {
        LinkedListNode3<T> head = null;
        LinkedListNode3<T> lastNode = null;
        foreach (var n in nums)
        {
            var node = new LinkedListNode3<T>(n);
            if (head == null)
            {
                head = node;
            }
            if (lastNode != null)
            {
                lastNode.next = node;
            }
            lastNode = node;
        }
        return head;
    }

    public static T[] ToArray<T>(this LinkedListNode3<T> head)
    {
        List<T> result = new List<T>();
        var c = head;
        while (c != null)
        {
            result.Add(c.val);
            c = c.next;
        }
        return result.ToArray();
    }

    public static void ConnectTo<T>(this LinkedListNode3<T> head, LinkedListNode3<T> what)
    {
        while (head.next!=null) head=head.next;
        head.next = what;
    }


    public static void Connect<T>(this LinkedListNode3<T> head, int whatIndex, int toIndex)
    {
        var nodes = new List<LinkedListNode3<T>>();

        while (head!=null) 
        {
            nodes.Add(head);
            head=head.next;
        }

        nodes[whatIndex].ConnectTo(nodes[toIndex]);
    }
}
