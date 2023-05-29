using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p5;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter3.Task3_5;

public class C3Lists_T3_5_Test
{
    [Fact]
    public void PushPopPeekIsEmptyAreCorrect()
    {
        var stack = new SortedStackByMin();

        stack.IsEmpty()
             .ShouldBe(true);

        stack.Push(2);
        stack.Push(1);

        stack.IsEmpty()
             .ShouldBe(false);

        stack.Peek()
             .ShouldBe(1);

        stack.Pop()
             .ShouldBe(1);

        stack.Pop()
             .ShouldBe(2);

        stack.IsEmpty()
             .ShouldBe(true);
    }

    [Fact]
    public void AfterPush_PopIsSorted()
    {
        var stack = new SortedStackByMin();

        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        stack.Pop()
             .ShouldBe(1);

        stack.Pop()
             .ShouldBe(2);

        stack.Pop()
             .ShouldBe(3);

        stack.Pop()
             .ShouldBe(4);
    }
}
