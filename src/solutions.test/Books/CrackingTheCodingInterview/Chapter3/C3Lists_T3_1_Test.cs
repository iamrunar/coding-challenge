using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.StacksFrom1Array;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter2
{
    public class C3Lists_T3_1_Test
    {
        [Fact]
        public void HeadStack()
        {
           var stackFactory = new StackFactory();
           var stacks = stackFactory.CreateThreeStacks();
           Should.Throw<InvalidOperationException>(()=>stacks[0].Pop());
           stacks[0].Push(1);
           stacks[0].Pop()
                    .ShouldBe(1);
           Should.Throw<InvalidOperationException>(()=>stacks[0].Pop());
        }

        [Fact]
        public void MiddleStack()
        {
           var stackFactory = new StackFactory();
           var stacks = stackFactory.CreateThreeStacks();
           Should.Throw<InvalidOperationException>(()=>stacks[1].Pop());
           stacks[1].Push(1);
           stacks[1].Pop().ShouldBe(1);
           Should.Throw<InvalidOperationException>(()=>stacks[1].Pop());
        }

        [Fact]
        public void TailStack()
        {
           var stackFactory = new StackFactory();
           var stacks = stackFactory.CreateThreeStacks();
           Should.Throw<InvalidOperationException>(()=>stacks[2].Pop());
           stacks[2].Push(1);
           stacks[2].Pop().ShouldBe(1);
           Should.Throw<InvalidOperationException>(()=>stacks[2].Pop());
        }
    }
}
