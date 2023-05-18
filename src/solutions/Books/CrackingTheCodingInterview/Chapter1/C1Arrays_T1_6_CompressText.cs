using System.Text;

namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_6_CompressText
{
    public string Compress(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1, j = 0; i<=text.Length; i++)
        {
            if (i==text.Length || text[i] != text[j])
            {
                sb.Append(toString(text[j], i - j));
                j = i;
            }
        }
        return sb.ToString();

        string toString(char c, int count)
        {
            return $"{c}{count}";
        }
    }
}