using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_2;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_2;

public class T4_2_Test
{
    [Theory]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 1,2 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1,2,3,4,5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1,2,3,4,5,6 })]
    public void GetSet(int[] input, int[] prefixTraversal)
    {
        new BinaryTreeFromArray()
            .Make(input)
            .GetOrderedArrayOfBST<int>()
            .Select(n => n == null ? -1 : n.Val)
            .ShouldBe(prefixTraversal);
    }
}
