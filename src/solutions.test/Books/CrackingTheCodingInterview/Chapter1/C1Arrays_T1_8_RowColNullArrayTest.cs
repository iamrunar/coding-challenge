using Shouldly;
using solutions.Books.CrackingTheCodingInterview.Chapter1;

namespace solutions.test.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_8_RowColNullArrayTest
{
    [Theory]
    [InlineData("abc|0ef|ghi", "0bc|000|0hi")]
    [InlineData("0ab|c0e|fgh|ijk","000|000|00h|00k")]
    [InlineData("behk|a0gj|0cfi", "00hk|0000|0000")]
    public void SetGet(string input, string expected)
    {
        new C1Arrays_T1_8_RowColNullArray()
            .CheckAndNull(To2dArray(input))
            .ShouldBe(To2dArray(expected));

        new C1Arrays_T1_8_RowColNullArray()
            .CheckAndNull2(To2dArray(input))
            .ShouldBe(To2dArray(expected));
    }

    char[][] To2dArray(string inputText) => inputText.Split('|').Select(t => t.ToCharArray()).ToArray();
}
