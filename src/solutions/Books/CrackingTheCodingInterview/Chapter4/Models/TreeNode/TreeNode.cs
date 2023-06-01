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