namespace solutions.Books.CrackingTheCodingInterview.Chapter1;

public class C1Arrays_T1_2_PolindromSolver
{
    /// <summary>
    /// dotnet structure
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool IsPolindrom(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;

        //cat <-> act ; cce <-!-> ece; aa <-!-> a
        Dictionary<char, int> contained = new Dictionary<char, int>();
        foreach (var c in s1)
        {
            if (!contained.TryAdd(c, 1))
            {
                contained[c]++;
            }
        }
        foreach (var c in s2)
        {
            if (!contained.ContainsKey(c))
            {
                return false;
            }
            else if (--contained[c] == 0)
            {
                contained.Remove(c);
            }
        }
        bool containsAElements = contained.Count == 0;
        return containsAElements;
    }

    /// <summary>
    /// Custom structure
    /// </summary>
    /// <param name="s1"></param>
    /// <param name="s2"></param>
    /// <returns></returns>
    public bool IsPolindrom2(string s1, string s2)
    {
        //aa ca ca aa
        if (s1.Length != s2.Length) return false;

        int[] contained = new int[256];
        foreach (var c in s1)
        {
            contained[c]++;
        }
        foreach (var c in s2)
        {
            if (contained[c] == 0)
            {
                return false;
            }
            else
            {
                --contained[c];
            }
        }
        return true;
    }
}
