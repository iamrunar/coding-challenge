using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p3;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter3.Task3_3;

public class C3Lists_T3_3_Test
{
    [Fact]
    public void PushPopAreCorrect()
    {
        var stack = new SetOfStack(2);

        stack.Push(1);
        stack.Push(2);

        stack.Push(3);
        stack.Push(4);

        stack.Push(5);
        stack.Push(6);

        stack.Stacks
             .Count
             .ShouldBe(3);

        stack.Stacks[0]
             .Count
             .ShouldBe(2);
        stack.Stacks[1]
             .Count
             .ShouldBe(2);
        stack.Stacks[2]
             .Count
             .ShouldBe(2);

        stack.Pop()
             .ShouldBe(6);
        stack.Pop()
             .ShouldBe(5);
        stack.Pop()
             .ShouldBe(4);
        stack.Pop()
             .ShouldBe(3);
        stack.Pop()
             .ShouldBe(2);
        stack.Pop()
             .ShouldBe(1);
    }
    [Fact]
    public void PushPopAtAreCorrect()
    {
        var stack = new SetOfStack(2);

        stack.Push(1);
        stack.Push(2);

        stack.Push(3);
        stack.Push(4);

        stack.Push(5);
        stack.Push(6);

        stack.PopAt(1)
             .ShouldBe(4);


        stack.Stacks
             .Count
             .ShouldBe(3);

        stack.Stacks[0]
             .Count
             .ShouldBe(2);
        stack.Stacks[1]
             .Count
             .ShouldBe(1);
        stack.Stacks[2]
             .Count
             .ShouldBe(2);
             
        stack.PopAt(1)
             .ShouldBe(3);

        stack.Stacks
             .Count
             .ShouldBe(2);

        stack.Pop()
             .ShouldBe(6);
        stack.Pop()
             .ShouldBe(5);
        stack.Pop()
             .ShouldBe(2);
        stack.Pop()
             .ShouldBe(1);
    }
}
