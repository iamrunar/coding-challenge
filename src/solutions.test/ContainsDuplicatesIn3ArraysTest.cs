namespace solutions.test.easy;
using Shouldly;
using solutions.easy;

/// <summary>
/// Даны три неубывающих массива чисел. Найти число, которое присутствует во всех трех массивах.
/// Input: [1,2,4,5], [3,3,4], [2,3,4,5,6]
/// Output: 4
/// Целевое решение работает за O(p + q + r), где p, q, r – длины массивов, доп. память O(1), но эту информацию интервьюер не сообщает.
/// https://github.com/Tinkoff/career/blob/main/interview/sections/programming.md
/// </summary>
public class ContainsDuplicatesIn3ArraysTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 4, 5 }, new[] { 3, 3, 4 }, new[] { 2, 3, 4, 5, 6 }, new[] { 4 })]
    [InlineData(new[] { 1, 5, 10, 20, 40, 80 }, new[] { 6, 7, 20, 80, 100 }, new[] { 3, 4, 15, 20, 30, 70, 80, 120 }, new[] { 20,80})]
    [InlineData(new[] { 1, 5, 5 }, new[] { 3, 4, 5, 5, 10 }, new[] { 5, 5, 10, 20 }, new[] { 5, 5 })]
    public void SetArrays_RT(int[]nums1, int [] nums2, int[] nums3, int []expected)
    {
        new ContainsDuplicatesIn3ArraysSolver()
            .GetFirstDuplicate(nums1, nums2, nums3)
            .ShouldBe(expected);
    }
}
