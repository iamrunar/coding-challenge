namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_6;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public class SearchNextOrderedNodeInBST
{
    public BinaryTreeNode<int>? GetNext(ParentedBinaryTreeNode<int> root, ParentedBinaryTreeNode<int> from)
    {
        if (from.Right != null) return GetLeftBottomNode(from.Right);

        return LeftParentNode(from);

        BinaryTreeNode<int> GetLeftBottomNode(ParentedBinaryTreeNode<int> c)
        {
            while (c.Left != null) c = (ParentedBinaryTreeNode<int>)c.Left;
            return c;
        }

        BinaryTreeNode<int>? LeftParentNode(ParentedBinaryTreeNode<int> c)
        {
            var parent = c.Parent;
            var child = c;
            while (parent != null && parent.Left != child)
            {
                child = parent;
                parent = parent.Parent;
            }
            return parent;
        }
    }
}

public class ParentedBinaryTreeNode<T> : BinaryTreeNode<T>
{
    public ParentedBinaryTreeNode() { }
    public ParentedBinaryTreeNode(T val, BinaryTreeNode<T>? left, BinaryTreeNode<T>? right)
        : base(val, left, right)
    {

    }

    public ParentedBinaryTreeNode<T>? Parent { get; set; }

    public new ParentedBinaryTreeNode<T>? Left
    {
        get => (ParentedBinaryTreeNode<T>?)base.Left;
        set => base.Left = value;
    }

    public new ParentedBinaryTreeNode<T>? Right
    {
        get => (ParentedBinaryTreeNode<T>?)base.Right;
        set => base.Left = value;
    }
    
    public static void EnrichNode(ParentedBinaryTreeNode<T> node, ParentedBinaryTreeNode<T>? parent)
    {
        node.Parent = parent;
    }
}
