using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_4_Test
{
    [Theory]
    [InlineData("Taco Coa", true)]
    [InlineData("Ab rab", true)]
    [InlineData("Ab qrab", false)]
    public void SetGet(string s1, bool expected)
    {
        new C1Arrays_T1_4_IsRearrangedPolindromSolver()
            .Check(s1)
            .ShouldBe(expected);

    }
}