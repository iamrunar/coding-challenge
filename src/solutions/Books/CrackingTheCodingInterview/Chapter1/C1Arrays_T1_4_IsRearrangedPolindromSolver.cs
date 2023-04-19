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
     * case 3. For ascii english only (from book) [English alphabit has 28 symbols]. So we use bitmap instead hashmap => bitmap[ch]=!bitmap[ch] => if bitmap == 0 then true; or ??? ;
     */
    public bool Check(string s1)
    {
        int oddCounter = 0;
        bool[] counter = new bool[256];
        foreach (var ch in s1)
        {
            if (Char.IsAsciiLetter(ch))
            {
                //toggle
                counter[Char.ToLower(ch)]=!counter[Char.ToLower(ch)];
            }
        }

        foreach (var c in counter)
        {
            if (c)
            {
                if (++oddCounter>1)
                {
                    return false;
                }
            }
        }
        return true;
    }

}

public class C1Arrays_T1_4_IsOneModificationSolver
{
    public bool IsOneModification(string s1, string s2)
    {
        if (Math.Abs(s1.Length - s2.Length) > 1) return false;

        int l = 0, r = 0;
        int modificationCounter = 0;
        while (l<s1.Length && r<s2.Length)
        {
            if (s1[l] == s2[r])
            {
                l++; r++;
                continue;
            }

            if (l == s1.Length - 1 || r == s2.Length - 1)
            {
                break;
            }

            if (s1[l] == s2[r+1])
            {
                r++;
                modificationCounter++;
                continue;
            }

            if (s1[l+1] == s2[r])
            {
                l++;
                modificationCounter++;
                continue;
            }

            l++; r++;
            modificationCounter++;
        }
        var numberOfDifferentSymbols = Math.Abs((s1.Length - l) - (s2.Length - r));
        modificationCounter += numberOfDifferentSymbols;
        return modificationCounter <= 1;
    }

    public bool IsOneModification2(string s1, string s2)
    {
        if (Math.Abs(s1.Length - s2.Length) > 1) return false;


        //s1 - smaller than s2. s1 -- can contain removed or modified symbols, but  s2 -- can contains added or modified symbols
        // s1 = ac s2 = abc
        // s1 = xa s2 = ba
        // s1 = ab s2 = cab
        string f1, f2;
        if (s1.Length<=s2.Length)
        {
            f1 = s1;
            f2 = s2;
        }
        else
        {
            f1 = s2;
            f2 = s1;
        }

        //one modification only: replace or add new symbol
        int l = 0, r = 0;
        bool modified = false;
        while (l < f1.Length)
        {
            if (f1[l] == f2[r])
            {
                l++; r++;
            }
            else
            {
                if (modified) return false;
                modified = true;
                if (f1.Length != f2.Length)
                {
                    r++; //added
                }
                else
                {
                    //replaced 
                    l++; r++;
                }
            }
        }
        return true;
    }
}