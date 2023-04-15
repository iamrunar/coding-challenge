namespace solutions.easy;

public class SquaresOfSortedArraySolver
{
    //nums in non-decreasing order
    public int[] SortedSquares(int[] nums)
    {
        int[] values = new int[nums.Length];
        for (int i = nums.Length-1, left = 0, right = nums.Length-1; i>=0;i--)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                values[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                values[i] = nums[right] * nums[right];
                right--;
            }
        }

        return values;
    }

}
