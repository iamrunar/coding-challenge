using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_3_Test
    {
        [Theory]
        [InlineData(new[] { 1,2 }, new int[]{2})]
        [InlineData(new[] { 1,2,3 }, new int[]{1,3})]
        [InlineData(new[] { 1,2,3,4 }, new int[]{1,3,4})]
        [InlineData(new[] { 1,2,3,4,5 }, new int[]{1,2,4,5})]
        [InlineData(new[] { 1,2,3,4,5,6 }, new int[]{1,2,4,5,6})]
        public void GetSet(int[] input, int[] expected)
        {
            var head = input.ToLinkedList();
            new C2Lists_T2_3_DeleteMiddleNode()
                .DeleteMiddleNode(ref head);

            head
                .ToArray()
                .ShouldBe(expected);
        }
    }
}
