namespace LeetCode;

public class Problem_448_FindAllNumbersDisappearedinanArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
                nums[index] *= -1;
        }

        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                result.Add(i + 1);
        }

        //1,2,2,3,4,7,8
        return result;
    }
}