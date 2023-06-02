using Shouldly;
using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_3;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_3;

public class T4_3_Test
{
    [Theory]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 2 }, new[] { 2 }, new[] { 1 })]
    [InlineData(new[] { 1, 2, 3 }, new[] { 2 }, new[] { 3, 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 4 }, new[] { 6, 2 }, new[] { 7, 5, 3, 1 })]
    public void GetSet(int[] input, params int[][] expectedArrays)
    {
        new LinkedListForEveryDepth()
            .GetLinkedListForEveryDepth(input.MakeSimpleBinaryTree(-1))
            .Select(l=>l.ToArray()).ToArray()
            .ShouldBe(expectedArrays);
    }
}
