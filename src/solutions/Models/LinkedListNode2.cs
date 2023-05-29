namespace solutions.Models;


public class LinkedListNode2Base<T>
{
    public LinkedListNode2Base<T> next;
    public T val;

    public LinkedListNode2Base(T val, LinkedListNode2Base<T> next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString();
    }
}

public class LinkedListNode2
{
    public LinkedListNode2 next;
    public int val;

    public LinkedListNode2(int val, LinkedListNode2 next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        return val.ToString();
    }
}

public static class LinkedListNodeHelper
{
    public static LinkedListNode2[] ToLinkedListArray(this int[][] lists)
    {
        return lists.Select(n => n.ToLinkedList()).ToArray();
    }

    public static LinkedListNode2 ToLinkedList(this int[] nums)
    {
        LinkedListNode2 head = null;
        LinkedListNode2 lastNode = null;
        foreach (var n in nums)
        {
            var node = new LinkedListNode2(n);
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

    public static int[] ToArray(this LinkedListNode2 head)
    {
        List<int> result = new List<int>();
        var c = head;
        while (c != null)
        {
            result.Add(c.val);
            c = c.next;
        }
        return result.ToArray();
    }

    public static void ConnectTo(this LinkedListNode2 head, LinkedListNode2 what)
    {
        while (head.next!=null) head=head.next;
        head.next = what;
    }


    public static void Connect(this LinkedListNode2 head, int whatIndex, int toIndex)
    {
        var nodes = new List<LinkedListNode2>();

        while (head!=null) 
        {
            nodes.Add(head);
            head=head.next;
        }

        nodes[whatIndex].ConnectTo(nodes[toIndex]);
    }
}