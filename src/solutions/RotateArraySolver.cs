namespace solutions.easy;

public class RotateArraySolver
{
    /// <summary>
    /// c O(n)
    ///     O(2*k)+O(n-k) = O(k)+O(n-k) + O(k) = O(n) + O(k) => k->n => O(2*n)
    /// m O(k)
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate2(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        if (k == 0) return;

        int[] buffer = new int[k];
        for (int i = 0; i<k; i++)
        {
            buffer[k - 1 - i] = nums[n - 1 - i];
        }

        for (int i = 0; i < n-k; i++)
        {
            nums[n - 1 - i] = nums[n - 1 - i - k];
        }

        for (int i = 0; i < k; i++)
        {
            nums[i] = buffer[i];
        }
    }


    /// <summary>
    /// Reverso by leetcode
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="k"></param>
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;
        if (k == 0) return;

        reverse(0, n - 1);
        reverse(0, k - 1);
        reverse(k, n - 1);

        void reverse(int l, int r)
        {
            while (l<r)
            {
                (nums[r], nums[l]) = (nums[l], nums[r]);
                l++; r--;
            }
        }
    }
}