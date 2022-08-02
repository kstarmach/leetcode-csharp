namespace LeetCode;

public class Problem_485_MaxConsecutiveOnes
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0;
        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] == 1)
            {
                temp++;
            }
            else
            {
                temp = 0;
            }

            if (temp > result)
                result = temp;
        }

        return result;
    }
}