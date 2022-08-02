namespace LeetCode;

public class Problem_1295_FindNumberswithEvenNumberofDigits
{
    public int FindNumbers(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
            {
                result++;
            }
        }

        return result;
    }
}