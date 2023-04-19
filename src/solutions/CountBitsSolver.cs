namespace solutions.easy;

public class CountBitsSolver
{
    public int GetCount(string nums)
    {
        int maxOne = 0;
        int? j = null;
        int i = 0;
        int zero = 0;
        for (; i < nums.Length; i++)
        {
            if (nums[i] == '0')
            {
                if (++zero>1)
                {
                    if (j.HasValue)
                        maxOne = Math.Max(i - j.Value - zero+1, maxOne);
                    j = null;
                }
            }
            else
            {
                if (j == null)
                {
                    j = i;
                    zero = 0;
                }
            }
        }
        if (j.HasValue)
        {
            maxOne = Math.Max(i - j.Value - zero, maxOne);
        }
        return maxOne;
    }
}