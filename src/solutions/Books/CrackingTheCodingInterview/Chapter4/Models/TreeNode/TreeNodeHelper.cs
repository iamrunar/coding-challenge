using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_2;

namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public static class TreeNodeHelper
{
    public static BinaryTreeNode<T> MakeBinaryTree<T>(this T[] input, T nullValue)
    {
        return Make(0, input.Length-1)!;

        //local functions
        BinaryTreeNode<T>? Make(int s, int e)
        {
            if (s>e) return null;

            var c = (s+e+1)/2;
            return object.Equals(input[c],nullValue) ? null : new BinaryTreeNode<T>(input[c], Make(s, c-1), Make(c+1,e));
        }
    }
        
    public static BinaryTreeNode<T>?[] SymmetricTrevel<T>(this BinaryTreeNode<T> root)
    {
        List<BinaryTreeNode<T>?> nodes = new ();
        f(root);
        return nodes.ToArray();

        void f(BinaryTreeNode<T>? node)
        {
            if (node == null) return;

            f(node?.Left);
            nodes.Add(node);
            f(node?.Right);
        }
    }
        
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