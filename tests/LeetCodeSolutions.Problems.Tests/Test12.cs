namespace LeetCodeSolutions.Problems.Tests;

public class Test12
{
    [Fact]
    public void RemoveElement_TestExample1()
    {
        // Arrange
        var solution = new _12.Solution();

        // Act
        var val = solution.IntToRoman(3749);

        // Assert
        Assert.Equal("MMMDCCXLIX", val);
    }
}