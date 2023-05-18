namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

/// <summary>
/// Checks if s1 is polindrom, but all words can be rearranged.
/// tact Coa  => taco cat => acto cta ... (+ upper \ lower case)
/// </summary>
public class C1Arrays_T1_4_IsRearrangedPolindromSolver
{
    /*
     * case 1. hashtable - with counter of every symbols => than count of odd => if > 1 => false cpu O(n)+O(n) mem O(n)
     * case 2. replace repeating symbols (even times:  coat ctoc => __a_ __c   ) => if we have more than 1 repeating symbols => false. cpu O(n^2) mem O(1) but in-place
     * case 3. For ascii english only (from book) [English alphabit has 28 symbols]. So we use bitmap instead ch=ch-'a' => hashmap => bitmap[ch]=!bitmap[ch] => if bitmap == 0 then true; or (bitmap & bitmap-1) == 0;
     */
    public bool Check(string s1)
    {
        int oddCounter = 0;
        bool[] oddTable = new bool[256];
        foreach (var ch in s1)
        {
            if (Char.IsAsciiLetter(ch))
            {
                //toggle
                bool isOdd;
                isOdd = oddTable[Char.ToLower(ch)] = !oddTable[Char.ToLower(ch)];

                if (isOdd) ++oddCounter;
                else --oddCounter;
            }
        }
        return oddCounter<=1;
    }

}
