namespace LeetCode;

public class Problem_27_RemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {

        // int i = 0;
        // foreach (var item in nums)
        // {
        //     if (item != val)
        //     {
        //         nums[i] = item;
        //         i++;
        //     }
        // }
        // return i;

        int position = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[position++] = nums[i];
            }

        }

        return position;
    }

}