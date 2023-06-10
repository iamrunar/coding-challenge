using System.Diagnostics;

namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

[DebuggerDisplay("Val={Val}")]
public class BinaryTreeNode<T>
{
    public BinaryTreeNode() {}

    public BinaryTreeNode(T val, BinaryTreeNode<T>? left, BinaryTreeNode<T>? right)
    {
        Val = val;
        Left = left;
        Right = right;
    }

    public T Val {get;set;} 

    public BinaryTreeNode<T>? Left {get;set;}
    public BinaryTreeNode<T>? Right {get;set;}

    public override string ToString() => $"{{ Val={Val} }}";
}