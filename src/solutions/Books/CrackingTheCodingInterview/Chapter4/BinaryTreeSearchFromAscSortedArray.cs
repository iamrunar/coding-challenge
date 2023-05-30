namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_2;

using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public class BinaryTreeSearchFromAscSortedArray
{
    public BinaryTreeNode<T> Make<T>(T []input)
    {
        return Make(0, input.Length-1)!;

        //local functions
        BinaryTreeNode<T>? Make(int s, int e)
        {
            if (s>e) return null;

            var c = (s+e+1)/2;
            return new BinaryTreeNode<T>(input[c], Make(s, c-1), Make(c+1,e));
        }
    }
}