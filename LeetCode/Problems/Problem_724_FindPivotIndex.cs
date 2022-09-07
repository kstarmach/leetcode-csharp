namespace LeetCode;

public class Problem_724_FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int leftSum = 0;
        int rightSum = nums.Sum();

        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (rightSum == leftSum)
            {
                return i;
            }
            
            leftSum += nums[i];
        }

        return -1;
    }
}