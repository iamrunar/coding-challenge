using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter2;
using solutions.Models;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C2Lists_T2_7_Test
    {
        [Theory]
        [InlineData(new[] { 1,2 }, new []{3,4,5}, new []{10,11})]
        [InlineData(new[] { 1,2 }, new []{3,4,5}, new int[0])]
        [InlineData(new[] { 1,2 }, new []{3,4}, new []{10,11})]
        public void GetSet(int[] array1, int[]array2, int[]tailOfArray1And2)
        {
            var list1 = array1.ToLinkedList<int>();
            var list2 = array2.ToLinkedList<int>();
            var tailOfList1And2 = tailOfArray1And2.ToLinkedList<int>();
            list1.ConnectTo(tailOfList1And2);
            list2.ConnectTo(tailOfList1And2);
            new C2Lists_T2_7_GetConnectionNode()
                .GetConnectionNode(list1, list2)
                .ShouldBe(tailOfList1And2);
            new C2Lists_T2_7_GetConnectionNode()
                .GetConnectionNode2(list1, list2)
                .ShouldBe(tailOfList1And2);
        }
    }
}
