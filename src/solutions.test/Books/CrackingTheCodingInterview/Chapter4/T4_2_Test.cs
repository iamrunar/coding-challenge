using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_2;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_1;

public class T4_2_Test
{
    [Theory]
    [InlineData(new []{1}, new []{1})]
    [InlineData(new []{1,2}, new []{2,1,-1})]
    [InlineData(new []{1,2,3},new []{2,1,3})]
    [InlineData(new []{1,2,3,4},new []{3,2,1,-1,4})]
    [InlineData(new []{1,2,3,4,5},new []{3,2,1,-1,5,4,-1})]
    [InlineData(new []{1,2,3,4,5,6},new []{4,2,1,3,6,5,-1})]
    public void GetSet(int []input, int []prefixTraversal)
    {
        new BinaryTreeSearchFromAscSortedArray()
            .Make(input)
            .PrefixVisitAllNode<int>()
            .Select(n=>n==null ? -1 : n.Val)
            .ShouldBe(prefixTraversal);
    }
}