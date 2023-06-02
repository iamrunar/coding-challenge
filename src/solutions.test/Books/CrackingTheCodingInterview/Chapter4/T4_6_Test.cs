using Shouldly;
using solutions.Models;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_6;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Tree;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_6;

public class T4_6_Test
{
    [Theory]
    [InlineData(new[] { 1 }, 1, null)]
    [InlineData(new[] { 1, 2 }, 1, 2)]
    [InlineData(new[] { 1, 2 }, 2, null)]
    [InlineData(new[] { 1, 2, 3 }, 1, 2)]
    [InlineData(new[] { 1, 2, 3 }, 2, 3)]
    [InlineData(new[] { 1, 2, 3 }, 3, null)]
    public void GetSet(int[] input, int currentNodeValue, int? expectedNextNodeValue)
    {
        var parentedBT = input.MakeBinaryTreeTyped<ParentedBinaryTreeNode<int>, int>(-1, ParentedBinaryTreeNode<int>.EnrichNode);
        var currentNode = parentedBT.FindNode(currentNodeValue);
        var expectedNode = expectedNextNodeValue == null ? null : parentedBT.FindNode(expectedNextNodeValue.Value);
        new SearchNextOrderedNodeInBST()
            .GetNext(parentedBT, (ParentedBinaryTreeNode<int>) currentNode)
            .ShouldBe(expectedNode);
    }
}