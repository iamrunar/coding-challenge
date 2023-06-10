using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Task4_1;
using solutions.Books.CrackingTheCodingInterview.Chapter4.Models.Graph;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter4.Task4_1;

public class T4_1_Test
{
    [Theory]
    [InlineData("a", "f", true
        , new[] { "a", "b", "c", "d" }
        , new[] { "b", "e" }
        , new[] { "d", "f" })]
    [InlineData("b", "f", false
        , new[] { "a", "b", "c", "d" }
        , new[] { "b", "e" }
        , new[] { "d", "f" })]
    public void EnqueueCat1yo_DequeuedCat1yo(string from, string to, bool expected, params string[][] adjacencyList)
    {
        var graph = adjacencyList.ToDirectedGraph();
        var fromNode = graph.Find(from)!;
        var toNode = graph.Find(to)!;

        new ConnectChecker()
            .IsConnected(fromNode,toNode)
            .ShouldBe(expected);
    }
}
