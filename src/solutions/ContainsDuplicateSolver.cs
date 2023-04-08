namespace solutions.easy;

public class ContainsDuplicateSolver
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashed = new HashSet<int>(nums.Length);
        foreach (var n in nums)
        {
            if (hashed.Contains(n))
            {
                return true;
            }

            hashed.Add(n);
        }
        return false;
    }
}