using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_2_Test
    {
        [Theory]
        [InlineData(new[] { 11, 7, 5, 3 }, 1, 5)]
        [InlineData(new[] { 11, 7, 5, 3 }, 0, 3)]
        [InlineData(new[] { 11, 7, 5, 3 }, 3, 11)]
        public void GetSet(int[] input, int k, int expected)
        {
            new C2Lists_T2_2_FindKElement()
                .FindKElement(input.ToLinkedList(), k)
                .ShouldBe(expected);
            new C2Lists_T2_2_FindKElement()
                .FindKElement2(input.ToLinkedList(), k)
                .ShouldBe(expected);
            new C2Lists_T2_2_FindKElement()
                .FindKElement3(input.ToLinkedList(), k)
                .ShouldBe(expected);
        }
    }
}
