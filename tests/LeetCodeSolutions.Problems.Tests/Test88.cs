namespace LeetCodeSolutions.Problems.Tests;

public class Test88
{
    [Fact]
    public void Merge_TestExample1()
    {
        // Arrange
        var solution = new _88.Solution();
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        int m = 3;
        int n = 3;

        // Act
        solution.Merge(nums1, m, nums2, n);

        // Assert
        var expected = new int[] { 1, 2, 2, 3, 5, 6 };
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_TestExample2()
    {
        // Arrange
        var solution = new _88.Solution();
        int[] nums1 = { 1 };
        int[] nums2 = { };
        int m = 1;
        int n = 0;

        // Act
        solution.Merge(nums1, m, nums2, n);

        // Assert
        var expected = new int[] { 1 };
        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_TestExample3()
    {
        // Arrange
        var solution = new _88.Solution();
        int[] nums1 = { 0 };
        int[] nums2 = { 1 };
        int m = 0;
        int n = 1;

        // Act
        solution.Merge(nums1, m, nums2, n);

        // Assert
        var expected = new int[] { 1 };
        Assert.Equal(expected, nums1);
    }
}