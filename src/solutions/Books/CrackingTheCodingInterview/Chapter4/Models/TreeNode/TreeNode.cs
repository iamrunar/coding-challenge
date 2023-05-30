namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public class BinaryTreeNode<T>
{
    public BinaryTreeNode(T val, BinaryTreeNode<T>? left, BinaryTreeNode<T>? right)
    {
        Val = val;
        Left = left;
        Right = right;
    }

    public T Val {get;} 

    public BinaryTreeNode<T>? Left {get;}
    public BinaryTreeNode<T>? Right {get;}
}


public static class TreeNodeHelper
{
    public static BinaryTreeNode<T>?[] PrefixVisitAllNode<T>(this BinaryTreeNode<T> root)
    {
        List<BinaryTreeNode<T>?> nodes = new ();
        v(root);
        return nodes.ToArray();

        void v(BinaryTreeNode<T>? c)
        {
            nodes.Add(c);

            if (c==null || c.Left==null && c.Right==null) return;

            v(c.Left);
            v(c.Right);
        }
    }
}