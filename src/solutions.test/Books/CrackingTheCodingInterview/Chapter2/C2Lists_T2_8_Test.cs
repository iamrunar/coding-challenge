using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_8_Test
    {
        [Theory]
        [InlineData(new[] { 1,2,3,4,5 }, 4,2, 3)]
        [InlineData(new[] { 1,2,3,4,5 }, 4,0, 1)]
        public void GetSet(int[] input, int connectWhat, int connectTo, int expectedRingNodeValue)
        {
            var list1 = input.ToLinkedList<int>();
            list1.Connect(connectWhat, connectTo);
            
            new C2Lists_T2_8_GetRingNode()
                .GetRingNode(list1)
                .ShouldBe(expectedRingNodeValue);
            new C2Lists_T2_8_GetRingNode()
                .GetRingNode2(list1)
                .ShouldBe(expectedRingNodeValue);
        }
    }
}
