using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;
namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_4;

public class BalancedChecker
{
    //warning! every the linkedlistnode has inverted order
    public bool IsBalanced<T>(BinaryTreeNode<T> root)
    {
        return f(root).HasValue;

        int? f(BinaryTreeNode<T>? node)
        {
            if (node == null) return 0;
            
            int? numberNodesInTheLeft = f(node?.Left);
            if(!numberNodesInTheLeft.HasValue)
            {
                return null;
            }
            int? numberNodesInTheRight = f(node?.Right);
            if(!numberNodesInTheRight.HasValue)
            {
                return null;
            }
            if (Math.Abs(numberNodesInTheLeft.Value - numberNodesInTheRight.Value)>1) return null;
            return numberNodesInTheLeft + numberNodesInTheRight + 1;
        }
    }
}