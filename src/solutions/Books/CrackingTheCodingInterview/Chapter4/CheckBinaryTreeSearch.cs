namespace solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_5;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

public class CheckBinaryTreeSearch
{
    public bool Check(BinaryTreeNode<int> root)
    {
        //1. make a symmetrical traversal => if it's b.s.t we get ordered array [1,2,3,4,5,6]
        //2. save the last visited item than compare it with the current element
        BinaryTreeNode<int>? prev = null;
        return visitSubitemAndCheck(root);

        bool visitSubitemAndCheck(BinaryTreeNode<int>? c)
        {
            if (c == null) return true;

            bool check = visitSubitemAndCheck(c?.Left) 
                        && PreviousLessOrNullThanStorePrev(c)
                        && visitSubitemAndCheck(c?.Right);

            return check;
        }

        //rw
        bool PreviousLessOrNullThanStorePrev(BinaryTreeNode<int> c)
        {
            if (prev != null && prev.Val > c.Val)
            {
                return false;
            }

            prev = c;
            return true;
        }
    }
}