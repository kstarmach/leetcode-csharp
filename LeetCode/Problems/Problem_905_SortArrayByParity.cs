namespace LeetCode;

public class Problem_905_SortArrayByParity
{
    public int[] SortArrayByParity(int[] nums)
    {
        int[] result = new int[nums.Length];
        int leftIndex = 0;
        int rightIndex = nums.Length - 1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[leftIndex++] = nums[i];
            }
            else
            {
                result[rightIndex--] = nums[i];
            }
        }

        return result;
    }
}