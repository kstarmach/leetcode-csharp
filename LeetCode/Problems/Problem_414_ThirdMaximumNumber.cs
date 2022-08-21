namespace LeetCode;

public class Problem_414_ThirdMaximumNumber
{
    public int ThirdMax(int[] nums)
    {
        Array.Sort(nums);
        int count = 0;

        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] != nums[i - 1])
            {
                count++;
                if (count == 2)
                    return nums[i - 1];
            }
        }

        return nums[nums.Length - 1];
    }
}