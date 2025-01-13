namespace LeetCodeSolutions.Problems._26;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int writeIndex = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[writeIndex-1] < nums[i])
            {
                nums[writeIndex++] = nums[i];
            }
        }

        return writeIndex;
    }
}
