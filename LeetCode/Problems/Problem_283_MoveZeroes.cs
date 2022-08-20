namespace LeetCode;

public class Problem_283_MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        // int[] new_nums = new int[nums.Length];
        // int position = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] != 0) new_nums[position++] = nums[i];
        // }

        // for (int j = 0; j < nums.Length; j++)
        // {
        //     nums[j] = new_nums[j];
        // }

        int position_of_last_zero = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0) nums[position_of_last_zero++] = nums[i];
        }

        for (int j = position_of_last_zero; j < nums.Length; j++)
        {
            nums[j] = 0;
        }
    }
}