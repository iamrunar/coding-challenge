using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_7_RotateArrayTest
{
    [Theory]
    [InlineData("abcd|efgh|ijkl|mnop", "miea|njfb|okgc|plhd")]
    [InlineData("ab|cd", "ca|db")]
    public void SetGet(string input, string expected)
    {
        new C1Arrays_T1_7_RotateArray()
            .Rotate(To2dArray(input))
            .ShouldBe(To2dArray(expected));
    }

    char[][] To2dArray(string inputText) => inputText.Split('|').Select(t => t.ToCharArray()).ToArray();
}
