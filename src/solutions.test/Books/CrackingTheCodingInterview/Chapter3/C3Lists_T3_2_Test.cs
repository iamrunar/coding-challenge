using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter3.Task3p2;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter3.Task3_2;

public class C3Lists_T3_2_Test
{
    public static IEnumerable<object[]> GetIStackWithMin() => new object[][] { new []{ new StackWithMinContext()}, new []{ new StackWithMinStack()} };

    [Theory]
    [MemberData(nameof(GetIStackWithMin))]
    public void StackisEmpty_PopThrownException(IStackWithMin stackImplementator)
    {
        var stack = stackImplementator;

        Should.Throw<InvalidOperationException>(() => stack.Pop());
    }

    [Theory]
    [MemberData(nameof(GetIStackWithMin))]
    public void AfterPush3_Pop3(IStackWithMin stackImplementator)
    {
        var stack = stackImplementator;

        stack.Push(3);
        stack.Pop()
             .ShouldBe(3);
    }

    [Theory]
    [MemberData(nameof(GetIStackWithMin))]
    public void BeforePush_MinNull(IStackWithMin stackImplementator)
    {
        var stack = stackImplementator;
        stack.Min()
             .ShouldBe(null);
    }

    [Theory]
    [MemberData(nameof(GetIStackWithMin))]
    public void AfterPush_MinUpdated(IStackWithMin stackImplementator)
    {
        var stack = stackImplementator;

        stack.Push(3);
        stack.Min()
             .ShouldBe(3);

        stack.Push(4);
        stack.Min()
             .ShouldBe(3);

        stack.Push(2);
        stack.Min()
             .ShouldBe(2);
    }

    [Theory]
    [MemberData(nameof(GetIStackWithMin))]
    public void AfterPop_MinWillBePrevious(IStackWithMin stackImplementator)
    {
        var stack = stackImplementator;

        stack.Push(4);
        stack.Min()
             .ShouldBe(4);

        stack.Push(2);
        stack.Min()
             .ShouldBe(2);

        stack.Pop();
        stack.Min()
             .ShouldBe(4);
    }
}
