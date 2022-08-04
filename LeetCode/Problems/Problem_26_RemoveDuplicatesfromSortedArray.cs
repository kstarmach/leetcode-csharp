namespace LeetCode;

public class Problem_26_RemoveDuplicatesfromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        List<int> temp = new List<int>();

        int i = 0;
        foreach (var item in nums)
        {
            if (!temp.Contains(item))
            {
                temp.Add(item);
                nums[i] = item;
                i++;
            }
        }

        return i;

    }
}