using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;
namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_3;

public class LinkedListForEveryDepth
{
    //warning! every the linkedlistnode has inverted order
    public IEnumerable<LinkedListNode3<T>> GetLinkedListForEveryDepth<T>(BinaryTreeNode<T> root)
    {
        List<LinkedListNode3<T>> listOfNodes = new ();
        f(0, root);
        return listOfNodes;

        void f(int depth, BinaryTreeNode<T> node)
        {
            if (node==null) return;

            Add(depth, node);

            if (node.Left!=null)
                f(depth+1, node.Left);

            if (node.Right!=null)
                f(depth+1, node.Right);
        }

        void Add(int depth, BinaryTreeNode<T> node)
        {
            LinkedListNode3<T> newItem = new LinkedListNode3<T>(node.Val);
            if (depth==listOfNodes.Count)
            {
                listOfNodes.Add(newItem);
            }
            else
            {
                newItem.next = listOfNodes[depth];
                listOfNodes[depth] = newItem;
            }
        }
    }
}