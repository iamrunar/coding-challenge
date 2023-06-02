using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_2;

namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public static class TreeNodeHelper
{
    //A simple and clear function to make binarytreenode
    public static BinaryTreeNode<T> MakeSimpleBinaryTree<T>(this T[] input, T nullValue)
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

    //A more complex but scalable implementation of makebinarytree
    //I don't want to break first implementation (because it was simple and clear) so I make duplicate
    //(also see Open-closed principle of SOLID [we mustn't break old implementation but should create new one]; 
    //but we remember that we shouldn't duplicate of code)
    public static TBinaryTreeNode MakeBinaryTreeTyped<TBinaryTreeNode, T>(this T[] input, T nullValue, Action<TBinaryTreeNode,TBinaryTreeNode?>? nodeEnricher = null) where TBinaryTreeNode: BinaryTreeNode<T>, new()
    {
        return Make(0, input.Length-1, null)!;

        //local functions
        TBinaryTreeNode? Make(int s, int e, TBinaryTreeNode? parent)
        {
            if (s>e) return null;

            var c = (s+e+1)/2;
            if (object.Equals(input[c],nullValue)) return null;

            var node = MakeBinaryTreeNode(input[c], parent);
            node.Left = Make(s, c-1, node);
            node.Right = Make(c+1,e, node);

            return node;
        }

       TBinaryTreeNode MakeBinaryTreeNode(T val, TBinaryTreeNode? parent)
        {
            var node = new TBinaryTreeNode()
            {
                Val = val,
            };

            nodeEnricher?.Invoke(node,parent);
            return  node;
        }
    }
        
    public static BinaryTreeNode<T>?[] GetOrderedArrayOfBST<T>(this BinaryTreeNode<T> rootOfBST)
    {
        List<BinaryTreeNode<T>?> nodes = new ();
        SymmetricTrevel(rootOfBST, n=>nodes.Add(n));
        return nodes.ToArray();
    }

    public static BinaryTreeNode<T>? FindNode<T>(this BinaryTreeNode<T> root, T val)
    {
       return SymmetricTrevel(root, n=>object.Equals(n.Val, val));
    }

    public static void SymmetricTrevel<T>(this BinaryTreeNode<T> root, Action<BinaryTreeNode<T>> visitor) =>
        SymmetricTrevel(root, n => { visitor(n); return false; });

    // visitHandler: if visitHandler return true => SymmetricTrevel finish and return handled node
    // ret: if handled => return handled node
    public static BinaryTreeNode<T>? SymmetricTrevel<T>(this BinaryTreeNode<T> root, Func<BinaryTreeNode<T>, bool> visitHandler)
    {
        BinaryTreeNode<T>? handledNode = null;
        f(root);

        return handledNode;


        bool f(BinaryTreeNode<T>? node)
        {
            if (node == null) return false;

            if (f(node.Left)) return true;

            if (visitHandler(node)) 
            {
                handledNode = node;
                return true;
            }

            if (f(node.Right)) return true;

           return false;
        }
    }
}