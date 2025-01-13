namespace LeetCodeSolutions.Problems.Tests;

public class Test27
{
    [Fact]
    public void RemoveElement_TestExample1()
    {
        // Arrange
        var solution = new _27.Solution();
        int[] nums1 = { 3, 2, 2, 3 };

        // Act
        var val = solution.RemoveElement(nums1, 3);

        // Assert
        Assert.Equal(2, val);
        Assert.Equal(2, nums1[0]);
        Assert.Equal(2, nums1[1]);
    }
}