using System.Collections;
using System.Xml.Linq;

namespace solutions.easy;



/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
public class LRUCache
{
    private DoubleLinkedListNode head;
    private DoubleLinkedListNode tail;
    private Dictionary<int, DoubleLinkedListNode> hashtable;
    private int capacity;

    public LRUCache(int capacity)
    {
        this.hashtable = new Dictionary<int, DoubleLinkedListNode>(capacity);
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        DoubleLinkedListNode node;
        if (!hashtable.TryGetValue(key, out node)) return -1;

        SetFirstList(node);
        return node.val;
    }

    public void Put(int key, int value)
    {
        if (hashtable.TryGetValue(key, out DoubleLinkedListNode listNode))
        {
            listNode.val = value;
            SetFirstList(listNode);
            return;
        }

        if (hashtable.Count == capacity)
        {
            var t = GetTail();
            hashtable.Remove(t.key);
            RemoveFromList(t);
        }

        var newListNode = new DoubleLinkedListNode(key, value);
        AddFirstToList(newListNode);
        hashtable.Add(key, newListNode);
    }

    void SetFirstList(DoubleLinkedListNode node)
    {
        RemoveFromList(node);
        AddFirstToList(node);
    }

    void AddFirstToList(DoubleLinkedListNode node)
    {
        var h = GetHead();
        if (h == node) return;

        var oldPrevNode = node.prev;
        if (oldPrevNode != null)
        {
            oldPrevNode.next = null;
        }

        node.prev = null;
        Connect(node, h);

        SetHead(node);
        if (GetTail() == null)
        {
            SetTail(node);
        }
    }

    void RemoveFromList(DoubleLinkedListNode node)
    {
        //store old connections
        DoubleLinkedListNode oldprevNode = node.prev;
        DoubleLinkedListNode oldnextNode = node.next;

        node.prev = null;
        node.next = null;

        if (oldprevNode != null)
        {
            Connect(oldprevNode, oldnextNode);
        }

        if (GetHead() == node)
        {
            SetHead(oldprevNode ?? oldnextNode);
        }

        if (GetTail() == node)
        {
            SetTail(oldnextNode ?? oldprevNode);
        }
    }

    DoubleLinkedListNode GetHead() => head;

    void SetHead(DoubleLinkedListNode listNode)
    {
        head = listNode;
    }

    DoubleLinkedListNode GetTail() => tail;

    void SetTail(DoubleLinkedListNode listNode)
    {
        tail = listNode;
    }

    void Connect(DoubleLinkedListNode from, DoubleLinkedListNode to = null)
    {
        from.next = to;
        if (to != null)
        {
            to.prev = from;
        }
    }

    class DoubleLinkedListNode
    {
        public DoubleLinkedListNode next;
        public DoubleLinkedListNode prev;
        public int val;
        public int key;

        public DoubleLinkedListNode(int key, int val, DoubleLinkedListNode next = null, DoubleLinkedListNode prev = null)
        {
            this.key = key;
            this.val = val;
            this.next = next;
            this.prev = prev;
        }

        public override string ToString()
        {
            return this.val.ToString();
        }
    }
}

public class LRUCache2
{
    private int capacity;
    private LinkedListMap<int, int> map;

    public LRUCache2(int capacity)
    {
        this.capacity = capacity;
        map = new LinkedListMap<int, int>();
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key)) return -1;
        map.SetFirst(key);

        return map[key];
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            map[key] = value;
            map.SetFirst(key);
            return;
        }


        if (map.Count == capacity)
        {
            map.RemoveLast();
        }

        map.AddFirst(key, value);
    }

    class LinkedListMap<TKey, TValue>
    {
        private LinkedList<Tuple<TKey, TValue>> list = new LinkedList<Tuple<TKey, TValue>>();
        private Dictionary<TKey, LinkedListNode<Tuple<TKey, TValue>>> hashtable = new Dictionary<TKey, LinkedListNode<Tuple<TKey, TValue>>>();

        public int Count => list.Count;

        public TValue this[TKey key]
        {
            get
            {
                return hashtable[key].Value.Item2;
            }
            set
            {
                hashtable[key].Value = new Tuple<TKey, TValue>(key, value);
            }
        }

        public bool ContainsKey(TKey key) => hashtable.ContainsKey(key);

        public void SetFirst(TKey key)
        {
            LinkedListNode<Tuple<TKey, TValue>> listNode;
            if (!hashtable.TryGetValue(key, out listNode))
            {
                return;
            }

            list.Remove(listNode);
            list.AddFirst(listNode);
        }

        public void AddFirst(TKey key, TValue value)
        {
            list.AddFirst(new Tuple<TKey, TValue>(key, value));
            hashtable.Add(key, list.First);
        }

        public void RemoveLast()
        {
            var last = list.Last;
            var lastItemTuple = last.Value;

            hashtable.Remove(lastItemTuple.Item1);
            list.RemoveLast();
        }
    }

}