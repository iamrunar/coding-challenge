namespace solutions.easy;

public class ContainsDuplicatesIn3ArraysSolver
{
    // три неубывающих массива чисел
    public IEnumerable<int> GetFirstDuplicate(int[] nums1, int[] nums2, int[] nums3)
    {
        List<int> result = new List<int>();
        int i = 0, j = 0, k = 0;
        for (;i<nums1.Length;i++)
        {
            while (j < nums2.Length && nums2[j] < nums1[i]) j++;
            if (j >= nums2.Length || nums2[j] > nums1[i]) continue;

            while (k < nums3.Length && nums3[k] < nums1[i]) k++;
            if (k >= nums3.Length || nums3[k] > nums1[i]) continue;

            if (nums3[k] == nums1[i])
            {
                result.Add(nums1[i]);
            }
        }
        return result;
    }
}
