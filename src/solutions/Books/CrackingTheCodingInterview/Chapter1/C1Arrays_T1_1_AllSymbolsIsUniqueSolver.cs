using System.Text;

namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

/// <summary>
/// Each symbol contains only one time
/// </summary>
public class C1Arrays_T1_1_AllSymbolsIsUniqueSolver
{
    /// <summary>
    /// Dotnet structure solution.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public bool CheckThatAllSymbolsIsUnique(string text)
    {
        HashSet<char> contained = new HashSet<char>();
        foreach (var ch in text)
        {
            if (contained.Contains(ch))
            {
                return false;
            }

            contained.Add(ch);
        }

        return true;
    }

    /// <summary>
    /// Custom structure.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public bool CheckThatAllSymbolsIsUnique2(string text)
    {
        bool[] contained = new bool[(1 << (Encoding.Default.GetByteCount("Ф")*8)) -1];
        foreach (var ch in text)
        {
            if (contained[ch])
            {
                return false;
            }

            contained[ch] = true;
        }

        return true;
    }
}
